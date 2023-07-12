using AvtoBazar.DataAccess.Utils;
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
    private IWebHostEnvironment _env;
    private readonly int maxPageSize = 30;
    public UsersController(IUserService userService)
    {
        this._userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        => Ok(await _userService.GetAllAsync(new PaginationParams(page, maxPageSize)));

    [HttpGet("count")]
    public async Task<IActionResult> CountAsync()
        => Ok(await _userService.CountAsync());


    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] UserCreateDto userCreateDto)
        => Ok(await _userService.CreateAsync(userCreateDto));

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(long id)
        =>Ok(await _userService.DeleteAsync(id));

    [HttpPut("{categoryId}")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] UserUpdateDto userUpdateDto)
        => Ok(await _userService.UpdateAsync(id, userUpdateDto));
        //=> Ok(await _userService.UpdateAsync(categoryId, userCreateDto));

    //[HttpGet]
    //public async Task<IActionResult> CountAsync()
    //=> Ok(await _userService.CountAsync());

}
