using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Invernadero_Digital.Models;

namespace Web_Invernadero_Digital.Controllers
{
    public class ControlCenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ILogger<ControlCenterController> _logger;

        public ControlCenterController(ILogger<ControlCenterController> logger)
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
