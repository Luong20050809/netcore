using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenVanLuong_2310900060.Models;

namespace NguyenVanLuong_2310900060.Controllers
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
