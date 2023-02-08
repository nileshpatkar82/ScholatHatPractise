using Lab_DataPassing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lab_DataPassing.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(model.Username == "user@gmail.com" && model.Password == "12345678")
                {
                    TempData["Message"] = "Welcome Back!";

                    string strUser = JsonSerializer.Serialize(model);

                    HttpContext.Session.SetString("User",strUser);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewBag.ErrorMessage = "Username or Password doesn't exists!";
                }
            }
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
