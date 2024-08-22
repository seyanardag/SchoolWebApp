namespace WebUI.UIDtos.RegisterDto
{
    public class RegisterUserDtoUI
    {
        public string NameForRegister { get; set; }
        public string SurnameForRegister { get; set; }
        public string UserNameForRegister { get; set; }
        public string EmailForRegister { get; set; }
        public string PasswordForRegister { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
