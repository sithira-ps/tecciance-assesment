using tecciance_assesment.Models;

namespace tecciance_assesment.Services;

public interface IProductService
{
    Task<Product> CreateAsync(Product product);
}