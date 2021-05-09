using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jobzy.Models
{
    public class Job
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="اسم الوظيفه")]
        public string jobTitle { get; set; }
        [Required]
        [Display(Name = "وصف الوظيفه")]
        public string jobDescription { get; set; }
       
        [Display(Name = "صورة الوظيفه")]
        public string jobImage { get; set; }
        [Required]
        [Display(Name = "نوع الوظيفه")]
        public int CategoryId { get; set; }
        public   Category Category { get; set; }

    }
}