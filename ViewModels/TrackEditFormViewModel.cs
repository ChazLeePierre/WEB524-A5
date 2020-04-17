using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class TrackEditFormViewModel
    {
        [Key]
        [Display(Name = "Track ID")]
        public int Id { get; set; }

        [Display(Name = "Track Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Track Audio")]
        [DataType(DataType.Upload)]
        public string AudioUpload { get; set; }

    }
}