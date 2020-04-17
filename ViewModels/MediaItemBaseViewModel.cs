using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class MediaItemBaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Added on date/time")]
        public DateTime Timestamp { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Unique identifier")]
        public string StringId { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Descriptive caption")]
        public string Caption { get; set; }
    }
}