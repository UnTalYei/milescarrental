using Domain.Models;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Infrastructure.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PickUpLocationController : ControllerBase
{
    private readonly ILocationRepository _locationRepository;

    public PickUpLocationController(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }


    // GET: api/<PickUpLocationController>
    [HttpGet]
    [Route("pickuplocations")]
    public async Task<IActionResult> GetPickupLocations()
    {
        IEnumerable<Location> pickupLocations = await _locationRepository.GetAllAsync();

        if (pickupLocations == null || !pickupLocations.Any())
        {
            return NotFound();
        }

        return Ok(pickupLocations);
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
