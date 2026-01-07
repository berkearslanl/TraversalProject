using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Commands.GuideCommand;
using TraversalCoreProje.CQRS.Queries.RehberQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RehberlerMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public RehberlerMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> RehberGetir(int id)
        {
            var values = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult RehberEkle()
        {
            return View();  
        }
        [HttpPost]
        public async Task< IActionResult> RehberEkle(CreateGuideCommands command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
