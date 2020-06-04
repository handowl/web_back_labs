using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WLab1.Controllers
{
    public class ControlsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index() => View();

        public IActionResult TextBox(string text)
        {
            ViewBag.Text = text;
            return View();
        }

        public IActionResult Textarea(string text)
        {
            ViewBag.Text = text;
            return View();
        }

        [HttpGet]
        public IActionResult CheckBox() => View();

        [HttpPost]
        public IActionResult CheckBox(int value)
        {
            ViewBag.Value = value;
            return View();
        }


        public IActionResult Radio(string value)
        {
            ViewBag.Value = value;
            return View();
        }

        public IActionResult DropDownList(string value)
        {
            ViewBag.Value = value;
            return View();
        }

        public IActionResult ListBox(string value)
        {
            ViewBag.Value = value;
            return View();
        }


    }
}
