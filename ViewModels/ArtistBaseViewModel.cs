using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class ArtistBaseViewModel
    {
        [Key]
        [Display(Name = "Artist ID")]
        public int Id { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Birth Name")]
        public string BirthName { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "Birth Or Start Date")]
        public DateTime BirthOrStartDate { get; set; }

        [Required, StringLength(200)]
        public string Executive { get; set; }

        [Required, StringLength(200)]
        public string Genre { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Artist Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Artist Image")]
        public string UrlArtist { get; set; }

        [DataType(DataType.MultilineText)]
        public string Portrayal { get; set; }
    }
}