using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.Dtos.iletisimDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class iletisimController : Controller
    {
        private readonly IBizeUlasinService _bizeUlasinService;
        private readonly IMapper _mapper;

        public iletisimController(IBizeUlasinService bizeUlasinService, IMapper mapper)
        {
            _bizeUlasinService = bizeUlasinService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(iletisimAddDto model)
        {

            if (ModelState.IsValid)
            {
                _bizeUlasinService.TEkle(new BizeUlasin()
                {
                    icerik = model.icerik,
                    Konu=model.Konu,
                    AdSoyad=model.AdSoyad,
                    Durum=true,
                    Mail=model.Mail,
                    Tarih = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy"))
                });
                return RedirectToAction("Index","Main");
            }
            return View(model);
        }
    }
}
