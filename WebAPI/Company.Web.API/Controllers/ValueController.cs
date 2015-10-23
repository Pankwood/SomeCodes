using Company.Business;
using Company.DomainModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Company.Web.API.Controllers
{
    public class ValueController : ApiController
    {
        // GET api/value
        public IEnumerable<Value> Get()
        {
            ValueBUS value = new ValueBUS();

            return value.Get();
        }

        // GET api/value/5
        public Value Get(string id)
        {
            ValueBUS value = new ValueBUS();
            return value.GetByID(id);
        }

        // POST api/value
        public IEnumerable<Value> Post([FromBody]Value pValue)
        {
            ValueBUS value = new ValueBUS();

            return value.Post(pValue);
        }

        // PUT api/value/5
        public IEnumerable<Value> Put(string id, [FromBody]Value pValue)
        {
            ValueBUS value = new ValueBUS();

            return value.Put(id, pValue);
        }

        // DELETE api/value/5
        public IEnumerable<Value> Delete(string id)
        {
            ValueBUS value = new ValueBUS();

            return value.Delete(id);
        }
    }
}
