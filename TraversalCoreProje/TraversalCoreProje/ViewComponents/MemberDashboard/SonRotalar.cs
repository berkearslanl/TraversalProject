using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class SonRotalar:ViewComponent
    {
        private readonly IVarisNoktalariService _varisNoktalariService;

        public SonRotalar(IVarisNoktalariService varisNoktalariService)
        {
            _varisNoktalariService = varisNoktalariService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _varisNoktalariService.Tson4rotalistele();
            return View(values);
        }
    }
}
