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
    IEnumerable<Location> GetLocations();
    Location GetLocationById(int id);
}
