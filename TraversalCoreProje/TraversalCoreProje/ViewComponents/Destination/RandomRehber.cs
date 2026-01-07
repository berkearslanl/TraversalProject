using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Destination
{
    public class RandomRehber:ViewComponent
    {
        private readonly IRehberlerService _rehberlerService;

        public RandomRehber(IRehberlerService rehberlerService)
        {
            _rehberlerService = rehberlerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _rehberlerService.TIdyeGoreGetir(1);
            return View(values);
        }
    }
}
