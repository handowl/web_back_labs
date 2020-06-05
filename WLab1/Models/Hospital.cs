using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WLab1.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<HospitalPhone> Phones { get; set; }

        public ICollection<Ward> Wards { get; set; }

        public ICollection<HospitalLab> Labs { get; set; }

        public ICollection<HospitalDoctor> Doctors { get; set; }
    }
}
