using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.ViewModels
{
    public class TrackEditViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public HttpPostedFileBase AudioUpload { get; set; }
    }
}