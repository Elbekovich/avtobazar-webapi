using AvtoBazar.DataAccess.Common.Interfaces;
using AvtoBazar.Domain.Entities.Categories;

namespace AvtoBazar.DataAccess.Interfaces.Categories;

public interface ICategoryRepository : IRepository<Category, Category>,IGetAll<Category>
{

}
