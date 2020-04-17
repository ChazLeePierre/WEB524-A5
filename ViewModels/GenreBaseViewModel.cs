using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class GenreBaseViewModel
    {
        [Key]
        [Display(Name="Genre Id")]
        public int Id { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Genre Name")]
        public string Name { get; set; }
    }
}