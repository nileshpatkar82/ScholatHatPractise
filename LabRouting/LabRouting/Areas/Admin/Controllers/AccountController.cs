using Microsoft.AspNetCore.Mvc;

namespace LabRouting.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
