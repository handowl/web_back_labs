using System.ComponentModel.DataAnnotations;
namespace WLab1.ViewModels
{
    public class EmailInput
    {
        [Required(ErrorMessage = "Введите email")]
        public string Email { get; set; }
    }

    public class CodeInput
    {
        [Required(ErrorMessage = "Код не может быть пустым")]
        public string Code { get; set; }

        public string GetCode() => Code;
    }
}
