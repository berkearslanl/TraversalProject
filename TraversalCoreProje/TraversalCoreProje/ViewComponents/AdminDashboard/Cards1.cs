using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class Cards1:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.VarisNoktalaris.Where(x => x.Durum == true).Count();
            ViewBag.v2 = c.Users.Count();
            return View();
        }
    }
}
