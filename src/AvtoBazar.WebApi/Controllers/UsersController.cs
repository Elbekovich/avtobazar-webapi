using AvtoBazar.Service.Dtos.Categories;
using AvtoBazar.Service.Dtos.Users;
using AvtoBazar.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace AvtoBazar.WebApi.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    IUserService _userService;
    public UsersController(IUserService userService)
    {
        this._userService = userService;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] UserCreateDto userCreateDto)
        => Ok(await _userService.CreateAsync(userCreateDto));
}
