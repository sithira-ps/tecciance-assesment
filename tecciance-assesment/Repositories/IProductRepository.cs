using tecciance_assesment.Models;

namespace tecciance_assesment.Repositories;

public interface IProductRepository
{
    Task<Product> CreateAsync(Product product);
}