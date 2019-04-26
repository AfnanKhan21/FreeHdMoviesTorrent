using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using FreeHdMoviesTorrent.Models;

namespace FreeHdMoviesTorrent.Services
{
    public class MovieDetail_Services
    {

        static HttpClient client = new HttpClient();
        public MovieDetail movieDetail = new MovieDetail();
        public async Task<MovieDetail> GetMovieDetails(int id)
        {
            HttpResponseMessage response = await client.GetAsync("https://yts.am/api/v2/movie_details.json?movie_id="+id+"&with_images=true&with_cast=true");

            if (response.IsSuccessStatusCode)
            {
                movieDetail = await response.Content.ReadAsAsync<MovieDetail>();

//                response.TryGetContentValue<MovieDetail>(out name);
            }

            return movieDetail;
        }
    }
}