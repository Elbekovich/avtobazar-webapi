using AvtoBazar.DataAccess.Interfaces.Categories;
using AvtoBazar.DataAccess.Repositories.Categories;
using AvtoBazar.Domain.Entities.Categories;
using AvtoBazar.Service.Common.Helpers;
using AvtoBazar.Service.Dtos.Categories;
using AvtoBazar.Service.Interfaces.Categories;
using Microsoft.AspNetCore.Mvc;

namespace AvtoBazar.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private IWebHostEnvironment _env;
    private ICategoryService _service;

    public CategoriesController(ICategoryService service)
    {
        this._service = service;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDto dto)
        =>Ok(await _service.CreateAsync(dto));
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(long categoryId)
        => Ok(await _service.DeleteAsync(categoryId));

    [HttpGet]
    public async Task<IActionResult> CountAsync()
    => Ok(await _service.CountAsync());

}
