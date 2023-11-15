using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/User")]
    public class CountryController : ApiController
    {

        static List<Country> cnt = new List<Country>()
        {
            new Country{ID=1, CountryName="India", Capital="Delhi"},
            new Country{ID=2, CountryName="Uinted State", Capital="Washington, D.C."}
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> Get()
        {
            return cnt;
        }


        [HttpPost]
        [Route("post")]
        public Country Post([FromBody] Country C)
        {
            cnt.Add(C);
            return C;
        }

        [HttpPut]
        [Route("put")]
        public void Put(int Id, [FromBody] Country C)
        {
            cnt[Id - 1] = C;
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete(int Id, [FromBody] Country C)
        {
            cnt.RemoveAt(Id - 1);
        }


    }
}
