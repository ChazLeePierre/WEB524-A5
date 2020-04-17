using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Assignment5.ViewModels
{
    public class ArtistAddFormViewModel : ArtistAddViewModel
    {
        [Display(Name = "Genre")]
        public SelectList GenreList { get; set; }
    }
}