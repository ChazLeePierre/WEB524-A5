using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class ArtistWithDetailViewModel : ArtistBaseViewModel
    {
        [Display(Name = "Albums")]
        public IEnumerable<AlbumBaseViewModel> Albums { get; set; }
    }
}