using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class Kullanicilar : Controller
    {
        private readonly IAppUserService
            _appUserService;

        private readonly IRezervasyonService _rezervasyonService;

        public Kullanicilar(IAppUserService appUserService, IRezervasyonService rezervasyonService)
        {
            _appUserService = appUserService;
            _rezervasyonService = rezervasyonService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TListele();
            return View(values);
        }
        public IActionResult KullaniciSil(int id)
        {
            var values = _appUserService.TIdyeGoreGetir(id);
            _appUserService.TSil(values);
            return RedirectToAction("Index");
        }

        public IActionResult KullaniciYorumlari(int id)
        {
            _appUserService.TListele();
            return View();
        }
        public IActionResult KullaniciTurlari(int id)
        {
            var values = _rezervasyonService.kabulEdilenRezervasyonListesi(id);
            return View(values);
        }
        public IActionResult RezervasyonSil(int id)
        {
            var values = _rezervasyonService.TIdyeGoreGetir(id);
            _rezervasyonService.TSil(values);
            return RedirectToAction("KullaniciTurlari");
        }

    }
}
