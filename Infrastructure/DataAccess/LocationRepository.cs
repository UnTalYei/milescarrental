using Domain.Models;
using Microsoft.EntityFrameworkCore;
using MilesCarRental.Infrastructure.Models;

namespace Infrastructure.DataAccess;
//public class LocationRepository : ILocationRepository
//{
//    private readonly ApplicationDbContext _context;

//    public LocationRepository(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IEnumerable<Location>> GetAllAsync()
//    {
//        return await _context.Locations.ToListAsync();
//    }

//    public async Task<Location> GetByIdAsync(int id)
//    {
//        return await _context.Locations.FindAsync(id);
//    }

//    public async Task AddAsync(Location location)
//    {
//        await _context.Locations.AddAsync(location);
//        await _context.SaveChangesAsync();
//    }

//    public async Task UpdateAsync(Location location)
//    {
//        _context.Locations.Update(location);
//        await _context.SaveChangesAsync();
//    }

//    public async Task DeleteAsync(int id)
//    {
//        var location = await _context.Locations.FindAsync(id);
//        if (location != null)
//        {
//            _context.Locations.Remove(location);
//            await _context.SaveChangesAsync();
//        }
//    }
////}

public class LocationRepository : ILocationRepository
{
    private readonly ApplicationDbContext _context;

    public LocationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Location> GetLocations()
    {
        return _context.Locations.ToList();
    }

    public Location GetLocationById(int id)
    {
        return _context.Locations.Find(id);
    }
}
