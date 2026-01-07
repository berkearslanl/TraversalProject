using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RotalarController : Controller
    {
        //VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());
        private readonly IVarisNoktalariService _varisNoktalariService;

        public RotalarController(IVarisNoktalariService varisNoktalariService)
        {
            _varisNoktalariService = varisNoktalariService;
        }

        public IActionResult Index()
        {
            var values = _varisNoktalariService.TSartaGoreListele(x => x.Durum == true);
            return View(values);
        }
        [HttpGet]
        public IActionResult RotaEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RotaEkle(VarisNoktalari p)
        {
            p.Durum = true;
            _varisNoktalariService.TEkle(p);
            TempData["AlertMessage"] = "Yeni rota başarıyla sisteme eklendi!";
            return RedirectToAction("Index");
        }
        public IActionResult RotaSil(int id)
        {
            var values = _varisNoktalariService.TIdyeGoreGetir(id);
            values.Durum = false;
            _varisNoktalariService.TGuncelle(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RotaGuncelle(int id)
        {
            var values = _varisNoktalariService.TIdyeGoreGetir(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult RotaGuncelle(VarisNoktalari p)
        {
            if (p.Durum = true)
            {
                p.Durum = true;
            }
            else
            {
                p.Durum = false;
            }
            _varisNoktalariService.TGuncelle(p);
            TempData["GuncellendiAlert"] = "Rota başarıyla güncellendi!";
            return RedirectToAction("Index");
        }
    }
}
