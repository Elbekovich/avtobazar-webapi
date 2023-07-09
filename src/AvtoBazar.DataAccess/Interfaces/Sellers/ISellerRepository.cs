using AvtoBazar.DataAccess.Common.Interfaces;
using AvtoBazar.Domain.Entities.Sellers;

namespace AvtoBazar.DataAccess.Interfaces.Sellers;

public interface ISellerRepository : IRepository<Seller, Seller> , IGetAll<Seller>, ISearchable<Seller>
{
}
