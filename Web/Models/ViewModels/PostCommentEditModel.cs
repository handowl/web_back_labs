using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.ViewModels
{
    public class PostCommentEditModel
    {
        [Required]
        public String Text { get; set; }
    }
}
