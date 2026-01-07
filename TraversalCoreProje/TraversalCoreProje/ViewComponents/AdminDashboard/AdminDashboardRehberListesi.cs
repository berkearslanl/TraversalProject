using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class AdminDashboardRehberListesi:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
