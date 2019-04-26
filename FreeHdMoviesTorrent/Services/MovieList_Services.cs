using FreeHdMoviesTorrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;


namespace FreeHdMoviesTorrent.Services
{
    public class MovieList_Services
    {

        static HttpClient client = new HttpClient();
        public MovieList movieList = new MovieList();
        public async Task<MovieList> GetMovieList(int page)
        {
            HttpResponseMessage response = await client.GetAsync("https://yts.am/api/v2/list_movies.json?page="+page);

            if (response.IsSuccessStatusCode)
            {
                movieList = await response.Content.ReadAsAsync<MovieList>();

                //                response.TryGetContentValue<MovieDetail>(out name);
            }

            return movieList;
        }
    }
}