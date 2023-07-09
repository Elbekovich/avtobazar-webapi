using AvtoBazar.DataAccess.Interfaces;
using AvtoBazar.DataAccess.Interfaces.Categories;
using AvtoBazar.DataAccess.Repositories.Categories;
using AvtoBazar.Domain.Entities.Categories;
using AvtoBazar.Domain.Exceptions.Categories;
using AvtoBazar.Service.Common.Helpers;
using AvtoBazar.Service.Dtos.Categories;
using AvtoBazar.Service.Interfaces.Categories;
using AvtoBazar.Service.Interfaces.Common;
using AvtoBazar.Service.Services.Common;
using System.Runtime.InteropServices;

namespace AvtoBazar.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryRepository;
    private IFileService _fileservice;

    public CategoryService(ICategoryRepository categoryRepository, IFileService fileService)
    {
        this._categoryRepository = categoryRepository;
        this._fileservice = fileService;
    }
    public async Task<long> CountAsync() => await _categoryRepository.CountAsync();
    public async Task<bool> CreateAsync(CategoryCreateDto dto)
    {
        string imagepath = await _fileservice.UploadImageAsync(dto.Image);
        Category category = new Category()
        {
            ImagePath = imagepath,
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = TimeHelper.GetDateTime(),
            UpdatedAt = TimeHelper.GetDateTime(),
        };
        var result = await _categoryRepository.CreateAsync(category);
        return result>0;

    }
    public async Task<bool> DeleteAsync(long categoryId)
    {
        var category = await _categoryRepository.GetByIdAsync(categoryId);
        if (category is null) throw new CategoryNotFoundException();
        var result = await _fileservice.DeleteImageAsync(category.ImagePath);
        if (result == false) throw new ImageNotFoundException();
        var dbResult = await _categoryRepository.DeleteAsync(categoryId);
        return dbResult > 0;
    }
}
