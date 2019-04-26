using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeHdMoviesTorrent.Models
{
    public class Torrent
    {
        public string Url { get; set; }
        public string Hash { get; set; }
        public string Quality { get; set; }
        public string Type { get; set; }
        public string Seeds { get; set; }
        public string Peers { get; set; }
        public string Size { get; set; }
        public string Size_Bytes { get; set; }
        public string Date_Uploaded_Unix { get; set; }
        public DateTime Date_Uploaded { get; set; }
    }
}