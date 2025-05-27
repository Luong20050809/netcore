using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nvllesson06.Models;

namespace Nvllesson06.Controllers
{
    public class NvlHomeController : Controller
    {
        private readonly ILogger<NvlHomeController> _logger;

        public NvlHomeController(ILogger<NvlHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvlIndex()
        {
            return View();
        }
        public IActionResult NvlAbout()
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
