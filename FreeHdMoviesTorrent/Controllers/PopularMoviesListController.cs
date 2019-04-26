using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FreeHdMoviesTorrent.Controllers
{
    public class PopularMoviesListController : ApiController
    {
        

        static HttpClient client = new HttpClient();
        // GET api/<controller>

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public async Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = await client.GetAsync("https://yts.am/api/v2/list_movies.json");

            //if (response.IsSuccessStatusCode)
            //{
            //    product = await response.Content.ReadAsAsync<Product>();
            //}

            return response;
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