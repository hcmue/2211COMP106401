using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Models;

namespace MyStore.Controllers
{
    public class DemoController : Controller
    {
        private readonly MyeStoreK46Context _context;

        public DemoController(MyeStoreK46Context context)
        {
            _context = context;
        }

        public IActionResult TimKiem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TimKiem(string? Keyword, double? From, double? To)
        {
            //var data = _context.HangHoas.Where(hh => hh.TenHh.Contains(Keyword) && hh.DonGia >= From && hh.DonGia <= To);

            //IQueryable vs IEnumerable
            var data = _context.HangHoas.AsQueryable();
            if (Keyword != null)
            {
                data = data.Where(hh => hh.TenHh.Contains(Keyword));
            }
            if (From != null)
            {
                data = data.Where(hh => hh.DonGia >= From);
            }
            if (To != null)
            {
                data = data.Where(hh => hh.DonGia <= To);
            }

            var result = data.Select(hh => new HangHoaView
            {
                MaHh = hh.MaHh, TenHh = hh.TenHh,
                DonGia = hh.DonGia, NgaySX = hh.NgaySx,
                Loai = hh.MaLoaiNavigation.TenLoai
            }).ToList();
            return View(result);
        }


        public IActionResult ThongKe()
        {
            var data = _context.ChiTietHds.GroupBy(hh => new { hh.MaHhNavigation.MaLoaiNavigation.TenLoai, hh.MaHhNavigation.MaLoai })
                .Select(g => new {
                    TenLoai = g.Key.TenLoai,
                    MaLoai = g.Key.MaLoai,
                    DoanhThu = g.Sum(cthd => cthd.SoLuong * cthd.DonGia),
                    GiaTB = g.Average(cthd => cthd.DonGia)
                });

            return View();
        }
    }
}
