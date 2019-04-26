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
    public class MovieSuggestionsApiController : ApiController
    {
        MovieSuggestions_Services _movieSuggestions_Services = new MovieSuggestions_Services();
        MovieSuggestions _movieSuggestions = new MovieSuggestions();
        // GET api/<controller>
        public async Task<String> Get()
        {
            _movieSuggestions = await _movieSuggestions_Services.GetMovieSuggestions(15);
            return _movieSuggestions.ToString();
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