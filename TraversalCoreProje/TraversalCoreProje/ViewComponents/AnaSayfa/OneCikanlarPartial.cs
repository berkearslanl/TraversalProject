using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AnaSayfa
{
    public class OneCikanlarPartial:ViewComponent
    {
        OneCikanlarManager ocm = new OneCikanlarManager(new EfOneCikanlarDal());
        VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());
        public IViewComponentResult Invoke()
        {
            var values = vnm.TListele().OrderBy(x => Guid.NewGuid()).Take(5).ToList();
            return View(values);

        }
    }
}
