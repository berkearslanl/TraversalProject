using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class YorumlarController : Controller
    {
        YorumlarManager ym = new YorumlarManager(new EfYorumlarDal());
        
        [HttpGet]
        public PartialViewResult YorumEkle()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult YorumEkle(Yorumlar p)
        {

            p.Tarih = Convert.ToDateTime(DateTime.Now.ToString("dd MM yyyy"));
            p.Durum = true;
            ym.TEkle(p);
            return RedirectToAction("Index", "Rotalar");
        }
    }
}
