using Microsoft.EntityFrameworkCore;
using tecciance_assesment.Data;
using tecciance_assesment.Models;

namespace tecciance_assesment.Repositories;

public class ProductsRepository : IProductRepository
{
    private AppDbContext _dbContext;

    public ProductsRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var productsList = await _dbContext.Products
            .ToListAsync();
        return productsList;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        var product = await _dbContext.Products
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync();
        return product;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        _dbContext.Products.Add(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }
}