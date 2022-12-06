using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get(int newsId)
        {

            return new string[] { "DÇ-2022: Danimarka Fransa ilə oyunda hesabı bərabərləşdirib - YENİLƏNİR - VİDEO",
                                  "Qətərdə keçirilən dünya çempionatının D qrupunun ikinci turunun Fransa - Danimarka matçında hesab dəyişib. Qarşılaşmanın 68-ci dəqiqəsində Andreas Kristensen Danimarkanın cavab qoluna imza atıb. 1:1",
                                  "1275"};
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
