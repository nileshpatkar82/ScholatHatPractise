using Lab_ComponentPartial.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_ComponentPartial.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel
            {
                id = 1,
                Title = "What is ASP.NET Core",
                Author = "Shailendra Chaouhan",
                Body="ASP.NET Core is open framework for building UI and API..."
            };

            return View(model);
        }
    }
}
