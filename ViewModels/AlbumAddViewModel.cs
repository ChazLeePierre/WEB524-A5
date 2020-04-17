using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class AlbumAddViewModel
    {
        public AlbumAddViewModel()
        {
            ReleaseDate = DateTime.Now;
        }

        public string Coordinator { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Album Name")]
        public string Name { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required]
        [Display(Name = "Album Image")]
        public string UrlAlbum { get; set; }

        [DataType(DataType.MultilineText)]
        public string Depiction { get; set; }
    }
}