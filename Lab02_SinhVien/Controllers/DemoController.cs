using Microsoft.AspNetCore.Mvc;

namespace Lab02_SinhVien.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile SingleFile)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HinhAnh", SingleFile.FileName);
            using (var myfile = new FileStream(fullPath, FileMode.Create))
            {
                SingleFile.CopyToAsync(myfile);
            }
            return View("Upload");
        }


        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> MultiFile)
        {
            foreach (var SingleFile in MultiFile)
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HinhAnh", SingleFile.FileName);
                using (var myfile = new FileStream(fullPath, FileMode.Create))
                {
                    SingleFile.CopyToAsync(myfile);
                }
            }
            return View("Upload");
        }
    }
}
