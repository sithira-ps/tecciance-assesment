namespace tecciance_assesment.Models;

public class Reservation
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ReservationKey { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }

    // navigation property
    public Product Product { get; set; }
}