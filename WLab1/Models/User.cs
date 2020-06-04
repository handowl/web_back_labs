using System;
using System.Security.Claims;

namespace WLab1.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }

        public static Person Instance { get; } = new Person();
    }
}
