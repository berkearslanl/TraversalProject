using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Yorumlar
{
    public class YorumListesi : ViewComponent
    {
        YorumlarManager ym = new YorumlarManager(new EfYorumlarDal());
        Context c = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.yorumSayisi = c.Yorumlars.Where(x => x.VarisNoktasiID == id).Count();
            var values = ym.TYorumListesiniRotaSehriyleveKullaniciylaGetir(id);
            return View(values);
        }
    }
}
