using Microsoft.AspNetCore.Mvc;

namespace TruyenDuLieu.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TenMon = "Công nghệ NET";
            return View();
        }

        public IActionResult OtherIndex()
        {
            ViewData["TenMon"] = ".NET Technology";
            return View("Index");
        }
    }
}
