using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class TrackAddViewModel
    {
        public string Clerk { get; set; }

        [Required, StringLength(200)]
        public string Composers { get; set; }

        public int GenreId { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Track Name")]
        public string Name { get; set; }

        public int AlbumId { get; set; }

        [Required]
        public HttpPostedFileBase AudioUpload { get; set; }
    }
}