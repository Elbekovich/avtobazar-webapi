using AvtoBazar.DataAccess.Common.Interfaces;
using AvtoBazar.DataAccess.ViewModels.Users;
using AvtoBazar.Domain.Entities.Users;

namespace AvtoBazar.DataAccess.Interfaces.Users;

public interface IUserRepository : IRepository<User, User>, IGetAll<User>, ISearchable<User>    
{
    public Task<UserViewModel> GetUserAsync(long id);
}
