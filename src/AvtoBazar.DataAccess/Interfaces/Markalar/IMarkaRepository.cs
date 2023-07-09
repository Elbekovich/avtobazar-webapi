using AvtoBazar.DataAccess.Common.Interfaces;
using AvtoBazar.Domain.Entities.Markalar;

namespace AvtoBazar.DataAccess.Interfaces.Markalar;

public interface IMarkaRepository : IRepository<Marka, Marka>, IGetAll<Marka>, ISearchable<Marka>
{

}
