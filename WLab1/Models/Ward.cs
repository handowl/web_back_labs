using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WLab1.Models
{
    public class Ward
    {
        public Int32 Id { get; set; }

        public Int32 HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        [Required]
        [MaxLength(200)]
        public String Name { get; set; }

        public ICollection<Placement> Placements { get; set; }
        public ICollection<WardStaff> WardStaffs { get; set; }
    }
}
