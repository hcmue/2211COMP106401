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

        public async Task<IActionResult> DemoBDD()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var a = DemoSyncAsync.AAsync();
            var b = DemoSyncAsync.BAsync();
            var c = DemoSyncAsync.CAsync();
            await a;
            await b;
            await c;
            Task.WaitAll();
            stopWatch.Stop();

            return Json(new
            {
                Type = "Async",
                Total = stopWatch.ElapsedMilliseconds
            });
        }
    }
}
