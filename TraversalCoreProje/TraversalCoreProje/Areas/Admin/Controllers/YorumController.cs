using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class YorumController : Controller
    {

        private readonly IYorumlarService _yorumlarService;

        public YorumController(IYorumlarService yorumlarService)
        {
            _yorumlarService = yorumlarService;
        }

        public IActionResult Index()
        {
            var values = _yorumlarService.YorumListesiniRotaSehriyleGetir().Where(x => x.Durum == true).ToList(); ;
            return View(values);
        }
        public IActionResult YorumSil(int id)
        {
            var values = _yorumlarService.TIdyeGoreGetir(id);
            values.Durum = false;
            _yorumlarService.TGuncelle(values);
            return RedirectToAction("Index");
        }
    }
}
