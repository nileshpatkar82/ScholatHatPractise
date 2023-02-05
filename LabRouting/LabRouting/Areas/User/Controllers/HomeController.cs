using Microsoft.AspNetCore.Mvc;

namespace LabRouting.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
