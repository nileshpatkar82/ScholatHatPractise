using Microsoft.AspNetCore.Mvc;

namespace LabRouting.Areas.User.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
