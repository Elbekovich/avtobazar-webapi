using AvtoBazar.DataAccess.Interfaces.Users;
using AvtoBazar.Domain.Entities.Users;
using AvtoBazar.Service.Common.Helpers;
using AvtoBazar.Service.Dtos.Users;
using AvtoBazar.Service.Interfaces.Users;

namespace AvtoBazar.Service.Services.Users;

public class UserService : IUserService
{
    //private readonly IUserService _userService;
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        this._userRepository = userRepository;          
    }
    public async Task<bool> CreateAsync(UserCreateDto userCreateDto)
    {
        User us = new User()
        {
            FirstName = userCreateDto.FirstName,
            LastName = userCreateDto.LastName,
            PhoneNumber = userCreateDto.PhoneNumber,
            PhoneNumberConfirmed = userCreateDto.PhoneNumberConfirmed,
            PassportSerialNumber = userCreateDto.PassportSerialNumber,
            IsMale = userCreateDto.IsMale,
            BirthDate = userCreateDto.BirthDate,
            Country = userCreateDto.Country,
            Region = userCreateDto.Region,
            PasswordHash = userCreateDto.PasswordHash,
            Salt = userCreateDto.Salt,
            CreatedAt = TimeHelper.GetDateTime(),
            UpdatedAt = TimeHelper.GetDateTime(),
            Role = userCreateDto.Role,
        };
        var res = await _userRepository.CreateAsync(us);
        return res > 0;
    }
}
