using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MilesCarRental.Controllers
{
    /// <summary>
    /// Create a new Contributor
    /// </summary>
    /// <remarks>
    /// Creates a new Contributor given a name.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class DropOffLocationController : ControllerBase
    {
        // XML Docs are used by default but are overridden by these properties:
        //s.Summary = "Create a new Contributor.";
        //s.Description = "Create a new Contributor. A valid name is required.";
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
