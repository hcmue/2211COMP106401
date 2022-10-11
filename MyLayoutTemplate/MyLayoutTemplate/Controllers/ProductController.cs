using Microsoft.AspNetCore.Mvc;

namespace MyLayoutTemplate.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
