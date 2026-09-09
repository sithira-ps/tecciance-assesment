using Microsoft.EntityFrameworkCore;
using tecciance_assesment.Data;
using tecciance_assesment.Repositories;
using tecciance_assesment.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=inventory.db"));

// services
builder.Services.AddScoped<IProductService, ProductService>();

// repositories
builder.Services.AddScoped<IProductRepository, ProductsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.MapControllers();
app.Run();