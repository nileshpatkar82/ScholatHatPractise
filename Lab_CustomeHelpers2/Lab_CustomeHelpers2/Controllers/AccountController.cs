using Microsoft.AspNetCore.Mvc;

namespace Lab_CustomeHelpers2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
