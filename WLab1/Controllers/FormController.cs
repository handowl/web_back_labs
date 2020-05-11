using Microsoft.AspNetCore.Mvc;
using WLab1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WLab1.Controllers
{
    public class FormController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public ViewResult ModelBindingPar()
        {
            Calculator model = new Calculator();
            return View(model);
        }

        [HttpPost]
        public IActionResult ModelBindingPar(int first, string operation, int second)
        {
            Calculator model = new Calculator(first, operation, second);

            if (!TryValidateModel(model, nameof(model))) return View(model);

            model.Result = Calculator.Calculate(first, operation, second);
            return View(model);
        }

        public ViewResult ModelBindingSep()
        {
            Calculator model = new Calculator();
            return View(model);
        }

        [HttpPost]
        public IActionResult ModelBindingSep(Calculator model)
        {
            if (!TryValidateModel(model, nameof(model))) return View(model);

            model.Result = Calculator.Calculate(model.First, model.Operation, model.Second);
            return View(model);
        }

        [HttpGet]
        public ViewResult ManualParsingSep()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManualParsingSep(int first, string operation, int second)
        {
            float result = Calculator.Calculate(first, operation, second);
            ViewBag.answer = $"{first} {operation} {second} = {result}";
            return View();
        }

        public IActionResult ManualParsingSingle(int first, string operation, int second)
        {
            if(Request.Method == "POST")
            {
                float result = Calculator.Calculate(first, operation, second);
                ViewBag.answer = $"{first} {operation} {second} = {result}";
            }
            return View();
        }

    }
}
