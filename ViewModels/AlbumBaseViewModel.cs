using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class AlbumBaseViewModel
    {
        [Key]
        [Display(Name = "Album ID")]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Coordinator { get; set; }

        [Required, StringLength(200)]
        public string Genre { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Album Name")]
        public string Name { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Album Image")]
        public string UrlAlbum { get; set; }

        [DataType(DataType.MultilineText)]
        public string Depiction { get; set; }
    }
}