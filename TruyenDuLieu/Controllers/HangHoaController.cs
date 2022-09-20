using Microsoft.AspNetCore.Mvc;
using TruyenDuLieu.Models;

namespace TruyenDuLieu.Controllers
{
    public class HangHoaController : Controller
    {
        static List<HangHoa> dsHangHoa = new List<HangHoa>()
        {
            new HangHoa{MaHh = 1, TenHh = "Dell 7440", GiaBan=5000, SoLuong = 1},
            new HangHoa{MaHh = 2, TenHh = "Dell Vostro 3420", GiaBan=215000, SoLuong = 19},
        };
        public IActionResult Index()
        {
            return View(dsHangHoa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HangHoa model)
        {
            dsHangHoa.Add(model);
            return View("Index", dsHangHoa);
        }
    }
}
