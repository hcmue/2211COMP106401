using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Models;
using System.Security.Claims;

namespace MyStore.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly MyeStoreK46Context _ctx;

        public KhachHangController(MyeStoreK46Context ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("/Login")]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View();
        }

        [HttpPost("/Login")]
        public async Task<IActionResult> Login(LoginVM model, string ReturnUrl = null)
        {
            //if (ModelState.IsValid)
            //{
            var khachHang = _ctx.KhachHangs.SingleOrDefault(p => p.MaKh == model.UserName && p.MatKhau == model.Password);
            if (khachHang == null)
            {
                ViewBag.Message = "Sai thông tin đăng nhập";
                ViewBag.ReturnUrl = ReturnUrl;
                return View();
            }

            //Claims
            var claims = new List<Claim> {
                    new Claim(ClaimTypes.Email, khachHang.Email),
                    new Claim(ClaimTypes.Name, khachHang.HoTen),
                    new Claim("ID", khachHang.MaKh),
                    new Claim(ClaimTypes.Role, "Admin"),
                };

            var claimsIdentity = new ClaimsIdentity(
        claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimPrincipal);

            if (ReturnUrl != null && Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }
            else
            {
                return Redirect("/Home");
            }
            //}
            //else
            //{
            //    ViewBag.Message = "Chưa nhập đủ thông tin";
            //    return View();
            //}
        }

        [HttpGet("/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Home");
        }
    }
}
