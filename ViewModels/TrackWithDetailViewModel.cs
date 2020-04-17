using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class TrackWithDetailViewModel : TrackBaseViewModel
    {
        public TrackWithDetailViewModel()
        {
            AlbumNames = new List<string>();
        }

        [Display(Name = "Albums")]
        public IEnumerable<string> AlbumNames { get; set; }
    }
}