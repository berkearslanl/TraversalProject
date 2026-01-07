using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class MemberLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
