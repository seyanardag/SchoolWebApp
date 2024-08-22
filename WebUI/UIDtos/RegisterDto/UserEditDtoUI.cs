using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebUI.UIDtos.RegisterDto
{
    public class UserEditDtoUI
    {
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [DisplayName("Soyad")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string? PasswordConfirm { get; set; }




        [Required(ErrorMessage = "Bu alan zorunludur")]
        [DisplayName("e-posta")]
        public string Email { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
