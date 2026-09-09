namespace tecciance_assesment.DTOs;

using System.ComponentModel.DataAnnotations;

public record CreateProductRequestDTO(
    [Required] string Name,
    [Required] string Sku,
    [Range(0, int.MaxValue)] int OnHand
);