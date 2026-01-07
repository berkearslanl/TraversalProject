using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AnaSayfa
{
    public class istatistikPartial:ViewComponent
    {
        VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());
        RehberlerManager rm = new RehberlerManager(new EfRehberlerDal());

        public IViewComponentResult Invoke()
        {
            var rotalar = vnm.TListele().Count();
            var rehberler = rm.TListele().Count();
            ViewBag.rotalar = rotalar;
            ViewBag.rehberler = rehberler;
            return View();
        }
    }
}
