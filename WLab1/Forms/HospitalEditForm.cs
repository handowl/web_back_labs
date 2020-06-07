﻿using System.ComponentModel.DataAnnotations;

namespace WLab1.Forms
{
    public class HospitalEditForm
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phones { get; set; }
    }
}