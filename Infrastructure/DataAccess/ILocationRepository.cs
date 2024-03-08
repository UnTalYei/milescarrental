using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using MilesCarRental.Infrastructure.Models;

namespace Infrastructure.DataAccess;
//internal class ILocationRepository
//{
//}
public interface ILocationRepository
{
    Task<IEnumerable<Location>> GetAllAsync();

    Task<Location> GetByIdAsync(int id);

    Task AddAsync(Location location);

    Task UpdateAsync(Location location);

    Task DeleteAsync(int id);
}
