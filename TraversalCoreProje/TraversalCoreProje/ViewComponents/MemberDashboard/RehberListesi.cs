using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class RehberListesi:ViewComponent
    {
        RehberlerManager rm = new RehberlerManager(new EfRehberlerDal());
        public IViewComponentResult Invoke()
        {
            var values = rm.TListele()
                   .OrderBy(x => Guid.NewGuid())
                   .Take(5)
                   .ToList();
            return View(values);
        }
    }
}
