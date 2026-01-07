using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class RehberlerController : Controller
    {
        RehberlerManager rm = new RehberlerManager(new EfRehberlerDal());

        public IActionResult Index()
        {
            var values = rm.TListele();
            return View(values);
        }
    }
}
