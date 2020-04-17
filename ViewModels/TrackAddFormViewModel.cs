using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Assignment5.ViewModels
{
    public class TrackAddFormViewModel : TrackAddViewModel
    {
        [Display(Name = "Album Name")]
        public string AlbumName { get; set; }

        [Display(Name = "Genre")]
        public SelectList GenreList { get; set; }

        [Required]
        [Display(Name = "Track Audio")]
        [DataType(DataType.Upload)]
        public string AudioUpload{ get; set; }

        //[Display(Name = "Album")]
        //public SelectList AlbumList { get; set; }
    }
}