using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WLab1.Models
{
    public class Lab
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<LabPhone> Phones { get; set; }

        public ICollection<HospitalLab> Hospitals { get; set; }
    }
}
