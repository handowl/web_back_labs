using System.ComponentModel.DataAnnotations;

namespace WLab1.Forms
{
    public class HospitalCreateForm
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phones { get; set; }
    }
}