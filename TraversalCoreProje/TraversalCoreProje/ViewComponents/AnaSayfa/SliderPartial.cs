using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AnaSayfa
{
    public class SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
