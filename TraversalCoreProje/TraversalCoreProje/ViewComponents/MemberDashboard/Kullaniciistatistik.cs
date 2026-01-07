using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class Kullaniciistatistik:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
