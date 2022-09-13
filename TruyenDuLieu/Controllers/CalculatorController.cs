using Microsoft.AspNetCore.Mvc;

namespace TruyenDuLieu.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(double SoHang01, double SoHang02, string PhepToan)
        {
            //var ketqua = $"{SoHang01} {PhepToan} {SoHang02} = ";
            //return Content(ketqua);
            ViewBag.SoHang01 = SoHang01;
            ViewBag.SoHang02 = SoHang02;
            ViewBag.PhepToan = PhepToan;
            double kq = 0;
            switch (PhepToan)
            {
                case "*": kq = SoHang01 * SoHang02; break;
                case "^": kq = Math.Pow(SoHang01, SoHang02); break;
            }
            ViewBag.KetQua = kq;
            return View("Index");
        }
    }
}
