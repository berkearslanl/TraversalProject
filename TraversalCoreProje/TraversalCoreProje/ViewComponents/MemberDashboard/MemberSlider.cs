using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class MemberSlider:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
