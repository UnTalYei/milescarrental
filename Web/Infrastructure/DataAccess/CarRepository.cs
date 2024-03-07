using MilesCarRental.Models;

namespace MilesCarRental.Infrastructure.DataAccess
{
    public class CarRepository : IRepository<Car>
    {
        private readonly MilesCarRentalContext _context;

        public CarRepository(MilesCarRentalContext context)
        {
            _context = context;
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task AddAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
        }

        public async Task UpdateAsync(Car car)
        {
            _context.Cars.Update(car);
        }

        public async Task DeleteAsync(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
        }
    }
}
