using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class TrackDeleteFormViewModel
    {
        [Key]
        [Display(Name = "Track ID")]
        public int Id { get; set; }

        [Display(Name = "Track Name")]
        public string Name { get; set; }
    }
}