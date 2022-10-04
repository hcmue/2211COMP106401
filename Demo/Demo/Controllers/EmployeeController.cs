using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //hợp lệ rồi ==> xử lý
            }
            else
            {
                ModelState.AddModelError("loi", "Server chưa hợp lệ");
            }
            return View();
        }
    }
}
