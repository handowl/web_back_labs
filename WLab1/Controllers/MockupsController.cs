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
        public IActionResult Index()
        {
            return View();
        }

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
            return View(userdata);
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
            return View(userdata);
        }

        [HttpGet]
        public IActionResult ResetPassword() => View();

        [HttpPost]
        public IActionResult ResetPassword(EmailInput data, string value)
        {
            if (ModelState.IsValid)
            {
                Person user = Person.Instance;
                if (data.Email == user.Email)
                {
                    user.Code = "322";
                    return View("InputCode");
                }
                else return View(data);
            }
            return View(data);

        }


        public IActionResult Check(CodeInput code)
        {
                Person user = Person.Instance;
                if (code.Code == user.Code)
                {

                    return View("Index");
                }else return View("InputCode");
        }
    }
}