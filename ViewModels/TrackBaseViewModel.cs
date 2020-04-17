using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class TrackBaseViewModel
    {
        [Key]
        [Display(Name = "Track ID")]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Clerk { get; set; }

        [Required, StringLength(200)]
        public string Composers { get; set; }

        [Required, StringLength(200)]
        public string Genre { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Track Name")]
        public string Name { get; set; }
    }
}