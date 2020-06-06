﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.ViewModels
{
    public class ForumTopicCreateModel
    {
        public DateTime Created { get; set; }
        [Required]
        public String Name { get; set; }
    }
}
