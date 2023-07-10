using AvtoBazar.Service.Dtos.Categories;
using AvtoBazar.Service.Dtos.Users;

namespace AvtoBazar.Service.Interfaces.Users;

public interface IUserService
{
    public Task<bool> CreateAsync(UserCreateDto userCreateDto);
    //public Task<bool> DeleteAsync(long userId);
    //public Task<long> CountAsync();
}
