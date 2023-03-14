using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModels
{
	public class ResetPasswordViewModel
	{
		[Required(ErrorMessage = "Lütfen email adresinizi giriniz.")]
		[EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi giriniz.")]
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
