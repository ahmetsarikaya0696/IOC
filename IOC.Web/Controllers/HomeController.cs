using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDateService _singletonDateService;
        private readonly IScopedDateService _scopedDateService;
        private readonly ITransientDateService _transientDateService;

        public HomeController(ISingletonDateService singletonDateService, IScopedDateService scopedDateService, ITransientDateService transientDateService)
        {
            _singletonDateService = singletonDateService;
            _scopedDateService = scopedDateService;
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices]ISingletonDateService _singletonDateService2, [FromServices]IScopedDateService _scopedDateService2, [FromServices]ITransientDateService _transientDateService2)
        {
            // Singleton
            ViewBag.SingletonTime1 = _singletonDateService.GetCurrentDate.ToString();
            ViewBag.SingletonTime2 = _singletonDateService2.GetCurrentDate.ToString();
            
            // Scoped
            ViewBag.ScopedTime1 = _scopedDateService.GetCurrentDate.TimeOfDay.ToString();
            ViewBag.ScopedTime2 = _scopedDateService2.GetCurrentDate.TimeOfDay.ToString();

            // Transient
            ViewBag.TransientTime1 = _transientDateService.GetCurrentDate.TimeOfDay.ToString();
            ViewBag.TransientTime2 = _transientDateService2.GetCurrentDate.TimeOfDay.ToString();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}