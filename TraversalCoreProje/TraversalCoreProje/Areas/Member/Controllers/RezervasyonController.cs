using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class RezervasyonController : Controller
    {
        VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());

        RezervasyonManager rm = new RezervasyonManager(new EfRezervasyonDal());

        private readonly UserManager<AppUser> _userManager;

        public RezervasyonController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> BenimAktifRezervasyonlarim()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rm.kabulEdilenRezervasyonListesi(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> BenimGecmisRezervasyonlarim()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rm.gecmisRezervasyonListesi(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> BenimOnayBekleyenRezervasyonlarim()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rm.onayBekleyenRezervasyonListesi(values.Id);
            return View(valuesList);
        }
        [HttpGet]
        public IActionResult YeniRezervasyon()
        {
            List<SelectListItem> list = (from x in vnm.TListele()
                                         select new SelectListItem
                                         {
                                             Text = x.Sehir,
                                             Value = x.VarisNoktasiID.ToString()
                                         }).ToList();
            ViewBag.l = list;
            return View();
        }
        //[HttpPost]
        //public IActionResult YeniRezervasyon(Rezervasyon p)
        //{
        //    p.AppUserID = 4;
        //    p.Durum = "Onay bekliyor";
        //    rm.TEkle(p);
        //    TempData["Rezervasyonbasarili"] = "Rezervasyonunuz başarıyla oluşturuldu.";
        //    return RedirectToAction("BenimAktifRezervasyonlarim");
        //}
        [HttpPost]
        public async Task<IActionResult> YeniRezervasyon(Rezervasyon p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserID = values.Id;
            p.Durum = "Onay bekliyor";
            rm.TEkle(p);
            TempData["Rezervasyonbasarili"] = "Rezervasyonunuz başarıyla oluşturuldu.";
            return RedirectToAction("BenimOnayBekleyenRezervasyonlarim", "Rezervasyon", new { area = "Member" });
        }
    }
}
