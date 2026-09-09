using Microsoft.AspNetCore.Mvc;
using tecciance_assesment.Models;
using tecciance_assesment.Repositories;
using tecciance_assesment.Services;

namespace tecciance_assesment.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> CreateAsync([FromBody] Product product)
    {
        await _productService.CreateAsync(product);
        return Ok();
    }
}