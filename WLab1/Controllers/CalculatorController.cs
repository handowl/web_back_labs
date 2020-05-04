using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WLab1.Models;

namespace WLab1.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Model()
        {
            Values model = new Values();
            return View(model);
        }

        public IActionResult UsingViewBag()
        {
            ViewBag.Value = new Values();
            return View();
        }

        public IActionResult UsingViewData()
        {
            ViewData["Value"] = new Values();
            return View();
        }

        public IActionResult Directly()
        {
            return View();
        }
    }
}
