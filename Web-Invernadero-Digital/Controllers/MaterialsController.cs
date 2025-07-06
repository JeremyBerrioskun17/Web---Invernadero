using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Invernadero_Digital.Models;

namespace Web_Invernadero_Digital.Controllers
{
    public class MaterialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ILogger<MaterialsController> _logger;

        public MaterialsController(ILogger<MaterialsController> logger)
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
