using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class AlbumWithDetailViewModel : AlbumBaseViewModel
    {
        [Display(Name = "Artists")]
        public IEnumerable<ArtistBaseViewModel> Artists { get; set; }

        [Display(Name = "Tracks")]
        public IEnumerable<TrackBaseViewModel> Tracks { get; set; }
    }
}