using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WLab1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WLab1.Controllers
{
    public class MockupsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            Exercises ex = new Exercises();
            Console.WriteLine("answer {0}", ex.InputAnswer);
            return View(ex);
        }

        [HttpPost]
        public IActionResult Quiz(Exercises Exercise, string action)
        {
            if (double.TryParse(Exercise.InputAnswer, out double InputAnswer) & ModelState.IsValid)
            {
                Answers answers = Answers.Instance;
                Console.WriteLine("Exercise answer {0}", Exercise.InputAnswer);
                answers.Total++;
                Exercise.Solve();
                if (Exercise.Check()) answers.Correct++;
                answers.Exercises.Add(Exercise);
            }
            else
            {
                ViewBag.NaN = "Not A Number";
                return View(Exercise);
            }

            if (action == "next") return View(new Exercises());
            if (action == "finish") return RedirectToAction("QuizResult");
            return View(Exercise);
        }

        public IActionResult QuizResult()
        {
            Answers answers = Answers.Instance;
            ViewBag.Result = answers.Exercises;
            ViewBag.Correct = answers.Correct;
            ViewBag.Total = answers.Total;
            return View();
        }
    }
}
