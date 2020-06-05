using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WLab1.Models;

namespace WLab1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About()
        {
            ViewData["Message"] = "Web lab by Elisey Trushkov.";
            ViewData["Message1"] = "discord - handowl#3724.";
            ViewData["Message2"] = "vk - id391491070 ";

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
