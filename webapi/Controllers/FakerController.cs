using Microsoft.AspNetCore.Mvc;
using webapi.Comun;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakerController : ControllerBase
    {

        private readonly DatosFake datosFake = new DatosFake();

        // GET: api/<FakerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return datosFake.GeneraArrCadenaLorem();
        }

        // GET api/<FakerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return datosFake.GeneraCadenaLorem(id);
        }

        // POST api/<FakerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FakerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FakerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
