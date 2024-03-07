using MilesCarRental.Models;

namespace MilesCarRental.Infrastructure.DataAccess
{
    public class LocationRepository : IRepository<Location>
    {
        private readonly MilesCarRentalContext _context;

        public LocationRepository(MilesCarRentalContext context)
        {
            _context = context;
        }

        public async Task<Location> GetByIdAsync(int id)
        {
            return await _context.Locations.FindAsync(id);
        }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task AddAsync(Location location)
        {
            await _context.Locations.AddAsync(location);
        }

        public async Task UpdateAsync(Location location)
        {
            _context.Locations.Update(location);
        }

        public async Task DeleteAsync(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(location);
        }
    }

}
