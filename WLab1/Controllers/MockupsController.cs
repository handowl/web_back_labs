using System;
using Microsoft.AspNetCore.Mvc;
using WLab1.Models;
using WLab1.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WLab1.Controllers
{
    public class MockupsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult SignUp() => View("SignUp");

        [HttpPost]
        public IActionResult SignUp(FirstStepSignUp userdata)
        {
            Person user = Person.Instance;
            if (ModelState.IsValid)
            {
                user.Name = userdata.Name;
                user.Surname = userdata.Surname;
                user.Birthday = userdata.Birthdate();
                user.Gender = userdata.Gender;
                return View("SignUpStep2");
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult SignUpStep2(SecondStepSignUp userdata)
        {
            if (ModelState.IsValid)
            {
                Person user = Person.Instance;
                user.Email = userdata.Email;
                user.Password = userdata.Password;
                return View("SignUpCredentials");
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult ResetPassword() => View();

        [HttpPost]
        public IActionResult ResetPassword(EmailInput data, string value)
        {
            if (value == "input") return View("InputCode");
            if (ModelState.IsValid)
            {
                if (data.Email == Person.Instance.Email)
                {
                    Person.Instance.Code = "322";
                    return View("InputCode");
                }
            }
            return BadRequest(ModelState);

        }


        public IActionResult Check(CodeInput viewCode)
        {
            if (viewCode.GetCode() == Person.Instance.Code) return View("Index");
            return BadRequest("Code is not correct");
        }
    }
}