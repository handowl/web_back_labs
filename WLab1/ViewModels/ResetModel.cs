using System.ComponentModel.DataAnnotations;
using WLab1.Models;
namespace WLab1.ViewModels
{
    public class EmailInput
    {
        [Required]
        [Compare(nameof(Models.Person.Email))]
        public string Email { get; set; }
    }

    public class CodeInput
    {
        [Required]
        [Compare(nameof(Models.Person.Code))]
        public string Code { get; set; }
    }
}
