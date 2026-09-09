using tecciance_assesment.Data;
using tecciance_assesment.Models;

namespace tecciance_assesment.Repositories;

public class ReservationRepository : IReservationRepository
{
    private AppDbContext _dbContext;

    public ReservationRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Reservation> CreateReservation(int productId, string reservationKey, int quantity)
    {
        var reservation = new Reservation
        {
            ProductId = productId,
            ReservationKey = reservationKey,
            Quantity = quantity,
            CreatedAt = DateTime.UtcNow
        };

        _dbContext.Reservations.Add(reservation);
        await _dbContext.SaveChangesAsync();
        return reservation;
    }
}