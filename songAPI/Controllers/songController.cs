using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace songAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class songController : ControllerBase
    {
        // GET: api/<songController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<songController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<songController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<songController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<songController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
