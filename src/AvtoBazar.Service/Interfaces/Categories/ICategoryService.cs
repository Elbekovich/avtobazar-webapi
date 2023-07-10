using AvtoBazar.Service.Dtos.Categories;
using AvtoBazar.Service.Dtos.Users;

namespace AvtoBazar.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDto dto);

    public Task<bool> DeleteAsync(long categoryId);

    public Task<long> CountAsync();
    
}
