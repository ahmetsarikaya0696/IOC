using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDateService _singletonDateService;

        public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService = singletonDateService;
        }

        public IActionResult Index([FromServices]ISingletonDateService _singletonDateService2)
        {
            ViewBag.SingletonTime1 = _singletonDateService.GetCurrentDate.ToString();
            ViewBag.SingletonTime2 = _singletonDateService2.GetCurrentDate.ToString();
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