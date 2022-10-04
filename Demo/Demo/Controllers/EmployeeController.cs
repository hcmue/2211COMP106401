using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult DangKy()
        {
            return View();
        }

        public IActionResult KiemTraMaNhanVienTrung(string EmployeeNo)
        {
            var dsMaDaCo = new string[] {
                "1111", "7777", "admin", "member"
            };
            if (dsMaDaCo.Contains(EmployeeNo))
            {
                return Json(data: "Mã này đã có");
            }
            return Json(data: true);
        }

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
