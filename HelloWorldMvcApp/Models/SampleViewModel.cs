﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMvcApp.Models
{
    public class SampleViewModel
    {
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        [Display(Name = "Ask the Genius a question:")]
        public string Question { get; set; }

        //See here for list of answers
        public string Answer { get; set; }

        public int Number { get; set; }
    }
}
