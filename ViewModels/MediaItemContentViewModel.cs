using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.ViewModels
{
    public class MediaItemContentViewModel : MediaItemBaseViewModel
    {
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
    }
}