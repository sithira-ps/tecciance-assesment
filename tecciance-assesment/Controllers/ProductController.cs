using Microsoft.AspNetCore.Mvc;
using tecciance_assesment.DTOs;
using tecciance_assesment.Models;
using tecciance_assesment.Repositories;
using tecciance_assesment.Services;

namespace tecciance_assesment.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private IProductService _productService;
    private IReservationService _reservationService;

    public ProductController(IProductService productService, IReservationService reservationService)
    {
        _productService = productService;
        _reservationService = reservationService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllAsync()
    {
        var products = await _productService.GetAllAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetByIdAsync(int id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateAsync([FromBody] CreateProductRequestDTO newProduct)
    {
        // convert product DTO to product entity
        var product = new Product
        {
            Name = newProduct.Name,
            Sku = newProduct.Sku,
            OnHand = newProduct.OnHand
        };

        var createdProduct = await _productService.CreateAsync(product);
        return CreatedAtAction(nameof(GetByIdAsync), new { id = createdProduct.Id }, createdProduct);
    }

    [HttpPost("{id}/reservations")]
    public async Task<ActionResult<Reservation>> CreateReservationAsync(int id, [FromBody] CreateReservationRequestDTO reservation)
    {
        var reservationKey = Guid.NewGuid().ToString();
        var createdReservation = await _reservationService.CreateReservation(id, reservationKey, reservation.Quantity);
        return Ok(createdReservation);
    }

}