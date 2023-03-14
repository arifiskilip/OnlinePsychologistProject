using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModels
{
	internal class RoleViewModel
	{
		public string Id { get; set; }
		[Display(Name = "Role Adı")]
		[Required(ErrorMessage = "Rol ismi boş geçilemez.")]
		public string Name { get; set; }
	}
}
