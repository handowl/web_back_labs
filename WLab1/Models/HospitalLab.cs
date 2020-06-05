namespace WLab1.Models
{
    public class HospitalLab
    {
        public int HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        public int LabId { get; set; }

        public Lab Lab { get; set; }
    }
}
