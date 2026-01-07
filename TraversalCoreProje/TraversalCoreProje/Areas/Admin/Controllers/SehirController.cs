using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class SehirController : Controller
    {
        private readonly IVarisNoktalariService _varisNoktalariService;

        public SehirController(IVarisNoktalariService varisNoktalariService)
        {
            _varisNoktalariService = varisNoktalariService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SehirListesi()
        {
            var jsonCity = JsonConvert.SerializeObject(_varisNoktalariService.TListele());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult sehirEkle(VarisNoktalari p)
        {
            p.Durum = true;
            _varisNoktalariService.TEkle(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult idyeGoreGetir(int VarisNoktasiID)
        {
            var values = _varisNoktalariService.TIdyeGoreGetir(VarisNoktasiID);
            var jsonvalues = JsonConvert.SerializeObject(values);
            return Json(jsonvalues);
        }

        public IActionResult sehirSil(int id)
        {
            var values = _varisNoktalariService.TIdyeGoreGetir(id);
            _varisNoktalariService.TSil(values);
            return NoContent();
        }

        public IActionResult sehirGuncelle(VarisNoktalari p)
        {
            _varisNoktalariService.TGuncelle(p);
            var jsonvalues = JsonConvert.SerializeObject(p);
            return Json(jsonvalues);
        }
    }
}
