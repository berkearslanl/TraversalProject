using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.Dtos.DuyurularDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DuyurularController : Controller
    {
        private readonly IDuyurularService _duyurularService;
        private readonly IMapper _mapper;

        public DuyurularController(IDuyurularService duyurularService, IMapper mapper)
        {
            _duyurularService = duyurularService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<DuyurularListDto>>(_duyurularService.TListele());
            return View(values);
        }
        [HttpGet]
        public IActionResult duyuruEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult duyuruEkle(DuyurularAddDto p)
        {
            if (ModelState.IsValid)
            {
                _duyurularService.TEkle(new Duyurular()
                {
                    icerik = p.icerik,
                    Baslik = p.Baslik,
                    Tarih = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy"))
                });
                return RedirectToAction("Index");
            }
            return View(p);

        }
        public IActionResult duyuruSil(int id)
        {
            var values = _duyurularService.TGetir(id);
            _duyurularService.TSil(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult duyuruGuncelle(int id)
        {
            var values = _mapper.Map<DuyurularUpdateDto>(_duyurularService.TGetir(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult duyuruGuncelle(DuyurularUpdateDto p)
        {
            if (ModelState.IsValid)
            {
                _duyurularService.TGuncelle(new Duyurular
                {
                    DuyurularID = p.DuyurularId,
                    Baslik = p.Baslik,
                    icerik = p.icerik,
                    Tarih = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy"))
                });
                return RedirectToAction("Index");
            }
            return View(p);
            
        }
    }
}
