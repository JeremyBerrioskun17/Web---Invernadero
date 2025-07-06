using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Invernadero_Digital.Models;

namespace Web_Invernadero_Digital.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ILogger<PruebaController> _logger;

        public PruebaController(ILogger<PruebaController> logger)
        {
            _logger = logger;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
