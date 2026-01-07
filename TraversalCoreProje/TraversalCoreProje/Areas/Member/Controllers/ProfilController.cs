using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfilController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfilController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.isim = values.Ad;
            userEditViewModel.soyisim = values.Soyad;
            userEditViewModel.mail = values.Email;
            userEditViewModel.telefonno = values.PhoneNumber;


            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.resim!=null)
            {
                var kaynak = Directory.GetCurrentDirectory();
                var uzanti = Path.GetExtension(p.resim.FileName);
                var resimismi = Guid.NewGuid() + uzanti;
                var konum = kaynak+"/wwwroot/userimages/"+resimismi;
                var akis = new FileStream(konum, FileMode.Create);
                await p.resim.CopyToAsync(akis);
                user.ResimUrl = resimismi;
            }
            user.Ad = p.isim;
            user.Soyad = p.soyisim;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.sifre);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("GirisYap","Login");
            }
            
            return View();
        }
    }
}
