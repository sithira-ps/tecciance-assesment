using tecciance_assesment.Models;
using tecciance_assesment.Repositories;

namespace tecciance_assesment.Services;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;

    public ProductService(IProductRepository  productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        await _productRepository.CreateAsync(product);
        return product;
    }
}