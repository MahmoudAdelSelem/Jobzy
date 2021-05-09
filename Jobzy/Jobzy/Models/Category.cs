using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jobzy.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = " نوع الوظيفه")]

        public string categoryName { get; set; }
        [Required]
        [Display(Name ="وصف النوع")]
        public string categoryDescription { get; set; }
    }
}