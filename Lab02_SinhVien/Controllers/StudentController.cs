using Microsoft.AspNetCore.Mvc;
using Lab02_SinhVien.Models;
using System.Text.Json;

namespace Lab02_SinhVien.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    string JsonFileName = "Student.json";
    string TxtFileName = "Student.txt";
    [HttpPost]
    public IActionResult Manage(Student sinhVien, string buttonName)
    {
        if (buttonName == "Ghi file JSON")
        {
            var jsonString = JsonSerializer.Serialize(sinhVien);
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", JsonFileName);
            System.IO.File.WriteAllText(fullPath, jsonString);
        }
        return View("Index", sinhVien);
    }

}
