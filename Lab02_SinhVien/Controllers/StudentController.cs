using Microsoft.AspNetCore.Mvc;
using Lab02_SinhVien.Models;

namespace Lab02_SinhVien.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Manage(Student sinhVien, string buttonName)
    {
        return View("Index");
    }

}
