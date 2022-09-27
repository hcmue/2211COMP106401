using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Sync()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            DemoSyncAsync.A();
            DemoSyncAsync.B();
            DemoSyncAsync.C();
            stopWatch.Stop();

            return Json(new { 
                Type = "Sync",
                Total = stopWatch.ElapsedMilliseconds
            });
        }
    }
}
