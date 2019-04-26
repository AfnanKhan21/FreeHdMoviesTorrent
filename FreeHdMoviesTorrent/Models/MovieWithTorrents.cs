using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeHdMoviesTorrent.Models
{
    public class MovieWithTorrents
    {
        public List<Torrent> Torrents { get; set; }
        public string Date_Uploaded_Unix { get; set; }
        public DateTime Date_Uploaded { get; set; }

        public int Id { get; set; }
        public string Url { get; set; }
        public string Imdb_Code { get; set; }
        public string Title { get; set; }
        public string Title_English { get; set; }
        public string Title_Long { get; set; }
        public string Slug { get; set; }
        public string Year { get; set; }
        public string Rating { get; set; }
        public string Runtime { get; set; }
        public string Download_Count { get; set; }
        public string Like_Count { get; set; }
        public string Description_Intro { get; set; }
        public string Description_Full { get; set; }
        public string Yt_Trailer_Code { get; set; }
        public string Language { get; set; }
        public string Mpa_Rating { get; set; }
        public string Background_Image { get; set; }
        public string Background_Image_Original { get; set; }
        public string Small_Cover_Image { get; set; }
        public string Medium_Cover_Image { get; set; }
        public string Large_Cover_Image { get; set; }
        public string Medium_Screenshot_Image1 { get; set; }
        public string Medium_Screenshot_Image2 { get; set; }
        public string Medium_Screenshot_Image3 { get; set; }
        public string Large_Screenshot_Image1 { get; set; }
        public string Large_Screenshot_Image2 { get; set; }
        public string Large_Screenshot_Image3 { get; set; }
        public List<String> Genres { get; set; }
    }
}