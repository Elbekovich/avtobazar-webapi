using AvtoBazar.DataAccess.Interfaces.Categories;
using AvtoBazar.DataAccess.Interfaces.Users;
using AvtoBazar.DataAccess.Repositories.Categories;
using AvtoBazar.DataAccess.Repositories.Users;
using AvtoBazar.Service.Interfaces.Categories;
using AvtoBazar.Service.Interfaces.Common;
using AvtoBazar.Service.Interfaces.Users;
using AvtoBazar.Service.Services.Categories;
using AvtoBazar.Service.Services.Common;
using AvtoBazar.Service.Services.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
