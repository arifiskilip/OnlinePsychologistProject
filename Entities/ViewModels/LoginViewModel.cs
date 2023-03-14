using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Entities.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Lütfen email adresinizi giriniz.")]
		[EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi giriniz.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Lütfen şifre alanını doldurun.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
