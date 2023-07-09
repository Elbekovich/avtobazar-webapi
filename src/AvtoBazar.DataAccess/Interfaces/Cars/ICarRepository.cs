using AvtoBazar.DataAccess.Common.Interfaces;
using AvtoBazar.Domain.Entities.Cars;

namespace AvtoBazar.DataAccess.Interfaces.Cars;

public interface ICarRepository : IRepository<Car , Car>,IGetAll<Car>, ISearchable<Car>
{

}
