using AvtoBazar.DataAccess.Interfaces.Users;
using AvtoBazar.DataAccess.Utils;
using AvtoBazar.DataAccess.ViewModels.Users;
using AvtoBazar.Domain.Entities.Users;
using Dapper;

namespace AvtoBazar.DataAccess.Repositories.Users;

public class UserRepository : BaseRepository, IUserRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateAsync(User entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.users(first_name, last_name, phone_number, phone_number_confirmed, passport_seria_number, is_male, birth_date, country, region, password_hash,salt,created_at, updated_at, role)" +
                "VALUES (@FirstName, " +
                "@LastName, " +
                "@PhoneNumber, " +
                "@PhoneNumberConfirmed, " +
                "@PassportSerialNumber, " +
                "@IsMale, " +
                "@BirthDate, " +
                "@Country, " +
                "@Region, " +
                "@PasswordHash," +
                "@Salt," +
                "@CreatedAt, " +
                "@UpdatedAt, " +
                "@Role);";
            var result = await _connection.ExecuteAsync(query, entity);
            return result;
        }
        catch { return 0; }
        finally { await _connection.CloseAsync(); }
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<User>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<UserViewModel> GetUserAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<(int ItemsCount, IList<User>)> SearchAsync(string search, PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, User entity)
    {
        throw new NotImplementedException();
    }
}
    