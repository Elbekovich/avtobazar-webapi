using Microsoft.AspNetCore.Http;

namespace AvtoBazar.Service.Dtos.Categories;

public class CategoryCreateDto
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;


    public IFormFile Image { get; set; } = default!;

    //public string ImagePath { get; set; } = string.Empty;

}
