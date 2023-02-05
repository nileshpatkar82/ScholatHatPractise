using Microsoft.AspNetCore.Mvc;

namespace LabRouting.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
