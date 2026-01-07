using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AnaSayfa
{
    public class AltHakkindaPartial:ViewComponent
    {
        AltHakkimizdaManager ahm = new AltHakkimizdaManager(new EfAltHakkimizdaDal());
        public IViewComponentResult Invoke()
        {
            var values = ahm.TListele().Take(1).ToList();
            return View(values);
        }
    }
}
