using Microsoft.AspNetCore.Mvc;
using MyLayoutTemplate.Models;
using MyLayoutTemplate.Repositories;
using System.Diagnostics;

namespace MyLayoutTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _cateRepo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository repo)
        {
            _cateRepo = repo;
            _logger = logger;
        }

        public IActionResult Categories()
        {
            return View(_cateRepo.GetAll());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}