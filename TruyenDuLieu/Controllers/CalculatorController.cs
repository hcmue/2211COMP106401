using Microsoft.AspNetCore.Mvc;

namespace TruyenDuLieu.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
