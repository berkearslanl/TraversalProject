using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class Rotalar : Controller
    {
        VarisNoktalariManager vnm = new VarisNoktalariManager(new EfVarisNoktalariDal());
        public IActionResult Index()
        {
            var values = vnm.TListele();
            return View(values);
        }
    }
}
