using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;

        private readonly SignInManager<AppUser> _signinmanager;

        public LoginController(UserManager<AppUser> usermanager, SignInManager<AppUser> signinmanager)
        {
            _usermanager = usermanager;
            _signinmanager = signinmanager;
        }

        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KayitOl(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Ad = p.Ad,
                Soyad = p.Soyad,
                Email = p.Mail,
                UserName = p.KullaniciAdi
            };
            if (p.Sifre == p.SifreTekrar)
            {
                var result = await _usermanager.CreateAsync(appUser, p.Sifre);
                if (result.Succeeded)
                {
                    return RedirectToAction("GirisYap");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var results = await _signinmanager.PasswordSignInAsync(p.KullaniciAdi, p.Sifre, false, true);
                if (results.Succeeded)
                {
                    TempData["LoginStatus"] = "Sisteme başarıyla giriş yaptınız!";
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    TempData["LoginStatus"] = "Error";
                    return RedirectToAction("GirisYap", "Login");
                }
            }
            return View();
        }
        public async Task<IActionResult> CikisYap()
        {
            await _signinmanager.SignOutAsync();

            return RedirectToAction("Index", "Main");
        }
    }
}
