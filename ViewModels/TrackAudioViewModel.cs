using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.ViewModels
{
    public class TrackAudioViewModel
    {
        public int Id { get; set; }
        public string AudioContentType { get; set; }
        public byte[] Audio { get; set; }
    }
}