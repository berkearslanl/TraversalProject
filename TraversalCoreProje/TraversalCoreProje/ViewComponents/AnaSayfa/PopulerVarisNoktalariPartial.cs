using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AnaSayfa
{
    public class PopulerVarisNoktalariPartial:ViewComponent
    {
        VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());
        public IViewComponentResult Invoke()
        {
            var values = vnm.TListele();
            return View(values);
        }
    }
}
