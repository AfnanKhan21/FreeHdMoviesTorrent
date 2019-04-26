using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeHdMoviesTorrent.Models
{
    public class MovieSuggestions
    {
        

        public string status { get; set; }
        public string status_message { get; set; }
        public data Data { get; set; }


        public struct data
        {
            public int Movie_Count { get; set; }
            public List<MovieWithTorrents> Movies { get; set; }
        };
    }
}