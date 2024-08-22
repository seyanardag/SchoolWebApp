using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.UIDtos.LoginDto;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<CustomUser> _signInManager;

        public LoginController(SignInManager<CustomUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Index(LoginDtoUI loginDtoUI)
        {

            var result = await _signInManager.PasswordSignInAsync(loginDtoUI.UserNameForLogin, loginDtoUI.PasswordForLogin, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Student");
            }

            return View("Index", loginDtoUI);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
