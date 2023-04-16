using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class DestinationController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public DestinationController(TravelApiContext db)
    {
      _db = db;
    }

    //GET : api/Destinations
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> GetDestinations()
    {
      return await _db.Destinations.Include(destination => destination.Reviews).ToListAsync();
    }

    //GET : api/Destinations/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
      var destination = await _db.Destinations
                                              .Include(destination => destination.Reviews)
                                              .FirstOrDefaultAsync(destination => destination.DestinationId == id);
                                       
      if (destination == null)
      {
        return NotFound();
      }
      
      return destination;
    }
    [HttpPost]
    public async Task<ActionResult<Destination>> Post(Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId}, destination);
    }
    //PUT: api/Destinations/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDestination(int id, Destination destination)
      {
      if (id != destination.DestinationId)
      {
        return BadRequest();
      }

      _db.Destinations.Update(destination);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DestinationExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool DestinationExists(int id)
    {
      return _db.Destinations.Any(e => e.DestinationId == id);
    }
  }
}