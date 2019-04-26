using FreeHdMoviesTorrent.Models;
using FreeHdMoviesTorrent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FreeHdMoviesTorrent.Controllers
{
    public class MovieListApiController : ApiController
    {
        MovieList_Services _movieList_Services = new MovieList_Services();
        MovieList _movieList = new MovieList();
        // GET api/<controller>
        public async Task<String> Get()
        {
            _movieList = await _movieList_Services.GetMovieList(15);
            return _movieList.ToString();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}