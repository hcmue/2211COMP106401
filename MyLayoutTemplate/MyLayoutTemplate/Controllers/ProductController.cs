using Microsoft.AspNetCore.Mvc;
using MyLayoutTemplate.Models;

namespace MyLayoutTemplate.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetCategories()
        {
            var data = new List<CategoryModel> {
                new CategoryModel{Id = 1, Name = "IPhone 14"},
                new CategoryModel{Id = 2, Name = "Mac Pro 2021"}
            };
            return PartialView("Category", data);
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
