using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class ProfilBilgi : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public ProfilBilgi(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Ad + " " + values.Soyad;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;
            ViewBag.linkedin = values.linkedin;
            ViewBag.github = values.github;
            ViewBag.instagram = values.instagram;
            return View();
        }
    }
}
