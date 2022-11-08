using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Models;

namespace MyStore.Controllers
{
    public class AjaxController : Controller
    {
        private readonly MyeStoreK46Context _context;

        public AjaxController(MyeStoreK46Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GioServer()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #region Search
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HandleSearch(string Keyword)
        {
            var data = _context.HangHoas.Where(p => p.TenHh.Contains(Keyword))
                .Select(p => new HangHoaView
                {
                    TenHh = p.TenHh,
                    MaHh = p.MaHh,
                    Loai = p.MaLoaiNavigation.TenLoai,
                    DonGia = p.DonGia, NgaySX = p.NgaySx
                })
                .ToList();
            return PartialView("HangHoa", data);
        }
        #endregion
    }
}
