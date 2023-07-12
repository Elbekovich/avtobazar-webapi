using AvtoBazar.DataAccess.Utils;
using AvtoBazar.Domain.Entities.Categories;
using AvtoBazar.Service.Dtos.Categories;

namespace AvtoBazar.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDto dto);

    public Task<bool> DeleteAsync(long categoryId);

    public Task<long> CountAsync();

    public Task<IList<Category>> GetAllAsync(PaginationParams @params);

    public Task<Category> GetByIdAsync(long categoryId);

    public Task<bool> UpdateAsync(long categoryId, CategoryUpdateDto dto);
}
