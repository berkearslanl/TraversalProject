using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class MemberLayoutLeftBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
