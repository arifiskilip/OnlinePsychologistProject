using Business.Abstract;
using Core.Helpers;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class HomeController : BaseController
    {
		private readonly ICustomerService _customerService;
        private readonly IContactService _contactService;
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICustomerService customerService, IContactService contactService)
            : base(userManager, signInManager)
        {
            _customerService = customerService;
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contactList = _contactService.GetAll().Where(x => x.Id == 1).FirstOrDefault();
            return View(contactList);
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            TempData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);
				if (user != null)
				{
					if (await _userManager.IsLockedOutAsync(user)) //kitliyse
					{
						ModelState.AddModelError("", "Hesabınız bir süreliğine kitlenmiştir. Lütfen daha sonra tekrar deneyiniz.");
						return View(model);
					}
					await _signInManager.SignOutAsync();
					Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync
						  (user, model.Password, model.RememberMe,false); //başarısızlık durumunda kitlensin mi ? = false
					if (result.Succeeded)
					{
						await _userManager.ResetAccessFailedCountAsync(user); //başarısız giriş sayısı sıfırlanır.
						if (TempData["ReturnUrl"] != null)
						{
							return Redirect(TempData["ReturnUrl"].ToString());
						}
						return RedirectToAction("Index", "Home");
					}
					else
					{
						await _userManager.AccessFailedAsync(user); //başarısız giriş sayısını 1 arttır.
						int fail = await _userManager.GetAccessFailedCountAsync(user);
						if (fail >= 3)
						{
							await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(
								DateTime.Now.AddMinutes(20))); //20 dakika kitle
							ModelState.AddModelError("", "Hesabınız çok fazla hatalı girişten dolayı bir süreliğine kitlenmiştir.");
						}
					}
				}
			}
			else
			{
				ModelState.AddModelError("", "Geçersiz email adresi veya şifresi.");
			}
			return View(model);
		}
		public IActionResult SignUp()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
					Customer customer = new Customer
					{
						FirstName = model.FirstName,
						LastName = model.LastName,
						AppUserId = user.Id,

					};
					_customerService.Add(customer);
                    return RedirectToAction("Login");
                }
                else
                {
                    AddModelErrors(result);
                }
            }
            return View(model);
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByEmailAsync(model.Email).Result;
                if (user != null)
                {
                    string passwordResetToken = _userManager.GeneratePasswordResetTokenAsync(user).Result; //ilgili kullanıcı için
                    string passwordResetLink = Url.Action("ResetPasswordConfirm", "Home", new
                    {
                        userId = user.Id,
                        token = passwordResetToken
                    }, HttpContext.Request.Scheme);
                    PasswordReset.PasswordResetSendMail(passwordResetLink, user.Email);
                }
                else
                {
                    ModelState.AddModelError("", "Sistemde kayıtlı email adresi bulunamamıştır.");
                }
            }
            return View(model);
        }

        public IActionResult ResetPasswordConfirm(string userId, string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPasswordConfirm([Bind("Password")] ResetPasswordViewModel model)
        {
            string userId = TempData["userId"].ToString();
            string token = TempData["token"].ToString();
            bool status = false;
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, token, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    status = true;
                    ViewBag.status = status;
                    return RedirectToAction("Login");
                }
                else
                {
                    AddModelErrors(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "Sistemde beklenmeyen bir hata meydana gelmiştir. Lütfen daha sonra tekrar deneyiniz.");
            }
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
