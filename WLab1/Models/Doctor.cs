using System.Collections.Generic;

namespace WLab1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public ICollection<HospitalDoctor> Hospitals { get; set; }
    }
}
