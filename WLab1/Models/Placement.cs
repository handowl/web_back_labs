namespace WLab1.Models
{
    public class Placement
    {
        public int Id { get; set; }
        public int Bed { get; set; }
        public int WardId { get; set; }
        public Ward Ward { get; set; }
    }
}
