using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_proj.Models
{
    public class ThemeColor
    {
        [Key]
        [Required]
        public string Color { get; set; }
    }
}