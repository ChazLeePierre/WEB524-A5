using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.ViewModels
{
    public class ArtistWithMediaViewModel : ArtistWithDetailViewModel
    {
        ArtistWithMediaViewModel()
        {
            MediaItems = new List<MediaItemContentViewModel>();
        }

        public IEnumerable<MediaItemContentViewModel> MediaItems { get; set; }
    }
}