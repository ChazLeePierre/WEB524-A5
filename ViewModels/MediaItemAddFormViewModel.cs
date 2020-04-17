using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class MediaItemAddFormViewModel
    {
        public int ArtistId { get; set; }

        [Display(Name = "Artist information")]
        public string ArtistInfo { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Descriptive caption")]
        public string Caption { get; set; }

        [Required]
        [Display(Name = "Media")]
        [DataType(DataType.Upload)]
        public string ContentUpload { get; set; }
    }
}