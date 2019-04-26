using FreeHdMoviesTorrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FreeHdMoviesTorrent.Services
{
    public class MovieSuggestions_Services
    {
        static HttpClient client = new HttpClient();
        public MovieSuggestions movieSuggestions = new MovieSuggestions();
        public async Task<MovieSuggestions> GetMovieSuggestions(int id)
        {
            HttpResponseMessage response = await client.GetAsync("https://yts.am/api/v2/movie_suggestions.json?movie_id="+id);

            if (response.IsSuccessStatusCode)
            {
                movieSuggestions = await response.Content.ReadAsAsync<MovieSuggestions>();

                //                response.TryGetContentValue<MovieDetail>(out name);
            }

            return movieSuggestions;
        }
    }
}