using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MilesCarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropOffController : ControllerBase
    {
        // GET: api/<PickUpLocationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PickUpLocationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PickUpLocationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PickUpLocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PickUpLocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
