using CokBasitUyelikSistemi.Filters;
using CokBasitUyelikSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CokBasitUyelikSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [GirisControl]
        public IActionResult Index()
        {
            return View();
        }
        [GirisControl]
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