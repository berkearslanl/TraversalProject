using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RehberlerController : Controller
    {
        private readonly IRehberlerService _rehberlerService;

        public RehberlerController(IRehberlerService rehberlerService)
        {
            _rehberlerService = rehberlerService;
        }

        public IActionResult Index()
        {
            var values = _rehberlerService.TListele();
            return View(values);
        }
        [HttpGet]
        public IActionResult RehberEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RehberEkle(Rehberler p)
        {
            p.Durum = true;
            _rehberlerService.TEkle(p);
            TempData["RehberEklendi"] = "Rehber ekleme işlemi başarılı!";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RehberGuncelle(int id)
        {
            var values = _rehberlerService.TIdyeGoreGetir(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult RehberGuncelle(Rehberler p)
        {
            if (p.Durum == true)
            {
                p.Durum = true;
            }
            else
            {
                p.Durum = false;
            }
            _rehberlerService.TGuncelle(p);
            TempData["RehberGuncellendi"] = "Rehber güncelleme işlemi başarılı!";
            return RedirectToAction("Index");
        }

        public IActionResult RehberPasifYap(int id)
        {
            var values = _rehberlerService.TIdyeGoreGetir(id);
            values.Durum = false;
            _rehberlerService.TGuncelle(values);
            return RedirectToAction("Index");
        }
        public IActionResult RehberAktifYap(int id)
        {
            var values = _rehberlerService.TIdyeGoreGetir(id);
            values.Durum = true;
            _rehberlerService.TGuncelle(values);
            return RedirectToAction("Index");
        }
    }
}
