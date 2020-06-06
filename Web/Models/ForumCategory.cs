using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ForumCategory
    {
        [Required]
        public String Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();

        public ICollection<Forum> Forums { get; set; }
    }
}
