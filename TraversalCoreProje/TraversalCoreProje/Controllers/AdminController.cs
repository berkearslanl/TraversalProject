using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class AdminController : Controller
    {
        
        public PartialViewResult BaslikPartial()
        {
            return PartialView();
        }
        public PartialViewResult LogoPartial()
        {
            return PartialView();
        }
        public PartialViewResult LeftSidePartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }
    }
}
