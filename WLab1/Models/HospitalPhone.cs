using System.ComponentModel.DataAnnotations;

namespace WLab1.Models
{
    public class HospitalPhone
    {
        public int HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        public int PhoneId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Number { get; set; }
    }
}
