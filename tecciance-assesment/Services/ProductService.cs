using tecciance_assesment.Models;
using tecciance_assesment.Repositories;

namespace tecciance_assesment.Services;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var productsList = await _productRepository.GetAllAsync();
        return productsList;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        return product;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        await _productRepository.CreateAsync(product);
        return product;
    }
}