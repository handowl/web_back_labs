using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WLab1.ViewModels
{
    public class FirstStepSignUp
    {
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Имя должно быть строкой от 2 до 20 симолов")]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Surname { get; set; }

        [Required]
        public string Day { get; set; }
        [Required]
        public string Month { get; set; }
        [Required]
        public string Year { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Gender { get; set; }

        public string Birthdate() {
            return Day + "/" + Month + "/" + Year;
        }
    }

    public class SecondStepSignUp
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "It is not email")]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Looks not like email.")]
        [StringLength(20, MinimumLength = 2)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 2)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "You are wrong! That is not correct")]
        [StringLength(20, MinimumLength = 2)]
        public string ConfirmPassword { get; set; }
    }
}
