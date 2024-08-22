using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class _ProfileVC : ViewComponent
    {
        private readonly UserManager<CustomUser> _userManager;

        public _ProfileVC(UserManager<CustomUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            return View(user);
        }       
    }
}
