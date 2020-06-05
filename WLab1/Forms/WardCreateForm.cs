using System.ComponentModel.DataAnnotations;

namespace WLab1.Forms
{
    public class WardCreateForm
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
