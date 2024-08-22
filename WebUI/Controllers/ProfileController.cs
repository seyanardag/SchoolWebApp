using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.UIDtos.RegisterDto;

namespace WebUI.Controllers
{
	public class ProfileController : Controller
	{
		private readonly UserManager<CustomUser> _userManager;

		public ProfileController(UserManager<CustomUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> UpdateProfile()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditDtoUI userEditDtoUI = new UserEditDtoUI()
			{
				Name = user.Name,
				Surname = user.Surname,
				UserName = user.UserName,
				Email = user.Email,
				ImageUrl = user.ImageUrl,
			
			};
			return View(userEditDtoUI);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateProfile(UserEditDtoUI userEditDtoUI)
		{

            if (!ModelState.IsValid)
            {
                return View(userEditDtoUI);
            }


            CustomUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            string oldImageUrl = user.ImageUrl;

            if (userEditDtoUI.ImageFile != null)
			{
				string resource = Directory.GetCurrentDirectory() + "/wwwroot/images/userImages/";
				string extension = Path.GetExtension(userEditDtoUI.ImageFile.FileName);

				string imageName = Guid.NewGuid().ToString() + extension;

				var saveLocation = resource + imageName;

				using var stream = new FileStream(saveLocation, FileMode.Create);

				await userEditDtoUI.ImageFile.CopyToAsync(stream);
				user.ImageUrl = "/images/userImages/" + imageName; ;

			} else
			{
				user.ImageUrl = oldImageUrl;
			}

			user.Surname = userEditDtoUI.Surname;
			user.Name = userEditDtoUI.Name;
			user.Email = userEditDtoUI.Email;



            if (!string.IsNullOrEmpty(userEditDtoUI.Password))
            {
                if (userEditDtoUI.Password != userEditDtoUI.PasswordConfirm)
                {
                    ModelState.AddModelError(string.Empty, "Şifreler uyuşmuyor.");
                    return View(userEditDtoUI);
                }

                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditDtoUI.Password);
            }


			//Kullanıcı Username i değiştirdiyse;
			if (userEditDtoUI.UserName != user.UserName)
			{
				user.UserName = userEditDtoUI.UserName;
				var result1 = await _userManager.UpdateAsync(user);

				if (result1.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				return View(userEditDtoUI);

			}

			//Kullanıcı Username i değiştirmediyse;
			user.UserName = userEditDtoUI.UserName;
			var result2 = await _userManager.UpdateAsync(user);

			if (result2.Succeeded)
			{
				return RedirectToAction("Index", "Student");
			}

			return View(userEditDtoUI);
		}
	}
}
