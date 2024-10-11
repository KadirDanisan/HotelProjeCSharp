using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _Admin()
        {
            return View();
        }

        public PartialViewResult HeapPartial()
        {
            return PartialView();
        }

        public PartialViewResult PreloaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavheaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }


        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }


        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
