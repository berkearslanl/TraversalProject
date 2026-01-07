using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AnaSayfa
{
    public class ReferanslarPartial:ViewComponent
    {
        ReferanslarManager rm = new ReferanslarManager(new EfReferanslarDal());
        public IViewComponentResult Invoke()
        {
            var values = rm.TListele();
            return View(values);
        }
    }
}
