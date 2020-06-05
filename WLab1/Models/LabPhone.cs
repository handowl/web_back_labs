using System.ComponentModel.DataAnnotations;

namespace WLab1.Models
{
    public class LabPhone
    {
        public int LabId { get; set; }

        public Lab Lab { get; set; }

        public int PhoneId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Number { get; set; }
    }
}
