using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModels
{
	public class PasswordChangeViewModel
	{
		[Required(ErrorMessage = "Eski şifreniz gereklidir.")]
		[DataType(DataType.Password)]
		public string PasswordOld { get; set; }

		[Required(ErrorMessage = "Yeni şifreniz gereklidir.")]
		[DataType(DataType.Password)]
		public string PasswordNew { get; set; }

		[Required(ErrorMessage = "Tekrar şifreniz gereklidir.")]
		[DataType(DataType.Password)]
		[Compare("PasswordNew", ErrorMessage = "Yeni şifreler birbiri ile aynı olmak zorundadır.")]
		public string PasswordConfirm { get; set; }
	}
}
