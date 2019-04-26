using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeHdMoviesTorrent.Models
{
   
    public class MovieList
    {
        public string status { get; set; }
        public string status_message { get; set; }
        public data Data { get; set; }


        public struct data
        {
            public List<MovieWithTorrents> movies { get; set; }
            public int Movie_Count { get; set; }
            public int Limit { get; set; }
            public int Page_Number { get; set; }
        };

    }
}