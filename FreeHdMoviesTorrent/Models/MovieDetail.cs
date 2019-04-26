using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeHdMoviesTorrent.Models
{
    
    public class MovieDetail
    {
        public string status { get; set; }
        public string status_message { get; set; }
        public data Data { get; set; }

        public struct data
        {
            public MovieWithTorrentsAndCast movie { get; set; }
        };
    }
}