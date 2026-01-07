using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class RotalarController : Controller
    {
        VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());

        private readonly UserManager<AppUser> _userManager;

        public RotalarController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index(string searchString)
        {
            ViewData["filtre"] = searchString;
            var values = from x in vnm.TListele() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.Sehir.Contains(searchString) || y.Aciklama.Contains(searchString) || y.DetayAciklama1.Contains(searchString) || y.DetayAciklama2.Contains(searchString));
            }
            return View(values.ToList());





            //var values = vnm.TListele();
            //return View(values);
        }
        //[HttpGet]
        //public async Task<IActionResult> turDetay(int id)
        //{
        //    ViewBag.i = id;
        //    var value = await _userManager.FindByNameAsync(User.Identity.Name);
        //    ViewBag.userId = value.Id;
        //    ViewBag.kadi = value.UserName;
        //    var values = vnm.TrehberleBirlikteRotaGetir(id);
        //    return View(values);
        //}
        [HttpGet]
        public async Task<IActionResult> turDetay(int id)
        {
            // 1. KONTROL: Kullanıcı giriş yapmış mı?
            if (!User.Identity.IsAuthenticated)
            {
                // Giriş yapmamışsa TempData ile mesaj oluştur ve Login'e yolla
                TempData["LoginGerekli"] = "Tur detaylarını görmek ve yorum yapabilmek için lütfen önce giriş yapınız.";
                return RedirectToAction("GirisYap", "Login"); // Login controller ve action adınıza göre güncelleyin
            }

            ViewBag.i = id;

            // 2. KONTROL: Kullanıcıyı getir
            var value = await _userManager.FindByNameAsync(User.Identity.Name);

            if (value != null)
            {
                ViewBag.userId = value.Id;
                ViewBag.kadi = value.UserName;
            }

            var values = vnm.TrehberleBirlikteRotaGetir(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult turDetay(VarisNoktalari p)
        {
            return View();
        }
    }
}
