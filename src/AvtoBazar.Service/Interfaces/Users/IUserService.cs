using AvtoBazar.DataAccess.Utils;
using AvtoBazar.Domain.Entities.Users;
using AvtoBazar.Service.Dtos.Users;

namespace AvtoBazar.Service.Interfaces.Users;

public interface IUserService
{
    public Task<bool> CreateAsync(UserCreateDto userCreateDto);
        
    public Task<bool> DeleteAsync(long id);

    public Task<long> CountAsync();

    public Task<IList<User>> GetAllAsync(PaginationParams @params);

    public Task<bool> UpdateAsync(long id, UserUpdateDto userUpdateDto);
}
