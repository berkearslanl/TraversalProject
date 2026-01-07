using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class bizeUlasinController : Controller
    {
        private readonly IBizeUlasinService _bizeUlasinService;

        public bizeUlasinController(IBizeUlasinService bizeUlasinService)
        {
            _bizeUlasinService = bizeUlasinService;
        }

        public IActionResult Index()
        {
            var values = _bizeUlasinService.TListele();
            return View(values);
        }
    }
}
