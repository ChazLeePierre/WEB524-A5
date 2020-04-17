using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class ArtistAddViewModel
    {
        public ArtistAddViewModel()
        {
            BirthOrStartDate = DateTime.Now;
        }

        [Required, StringLength(200)]
        [Display(Name = "Artist Name")]
        public string Name { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Artist Birth Name")]
        public string BirthName { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "Artist Birth or Start Date")]
        public DateTime BirthOrStartDate { get; set; }

        public string Executive { get; set; }

        public int GenreId { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Artist Image")]
        [Required]
        public string UrlArtist { get; set; }

        [DataType(DataType.MultilineText)]
        public string Portrayal { get; set; }
    }
}