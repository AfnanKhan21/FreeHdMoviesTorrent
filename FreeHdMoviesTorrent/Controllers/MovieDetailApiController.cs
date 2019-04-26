using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FreeHdMoviesTorrent.Services;
using FreeHdMoviesTorrent.Models;

namespace FreeHdMoviesTorrent.Controllers
{
    public class MovieDetailApiController : ApiController
    {
        MovieDetail_Services _movieDetail_Services = new MovieDetail_Services();
        MovieDetail _movieDetail = new MovieDetail();
        // GET api/<controller>
        public async Task<String> Get()
        {
            _movieDetail =  await _movieDetail_Services.GetMovieDetails(15);
            return _movieDetail.ToString();
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