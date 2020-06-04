using System.ComponentModel.DataAnnotations;
namespace WLab1.ViewModels
{
    public class EmailInput
    {
        [Required]
        public string Email { get; set; }
    }

    public class CodeInput
    {
        [Required]
        public string Code { get; set; }

        public string GetCode() => Code;
    }
}
