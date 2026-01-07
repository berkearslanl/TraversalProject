using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class MainController : Controller
    {
        HaberBulteniManager hbm = new HaberBulteniManager(new EfHaberBulteniDal());

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult üyeOl(HaberBülteni p)
        {
            var mevcutMail = hbm.TListele().FirstOrDefault(x => x.Mail == p.Mail);

            if (mevcutMail != null)
            {
                // Eğer mail zaten varsa hata mesajı gönder
                TempData["MesajHata"] = "Bu mail adresi zaten bültenimize kayıtlı!";
            }
            else
            {
                // 2. Adım: Eğer mail yoksa ekleme işlemini yap
                hbm.TEkle(p);
                TempData["MesajBasarili"] = "Bültenimize başarıyla abone oldunuz.";
            }

            // İşlem bittikten sonra formu içeren sayfaya geri dön (Örn: Index sayfası)
            return RedirectToAction("Index");
        }
    }
}
