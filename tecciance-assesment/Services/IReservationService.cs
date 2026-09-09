using tecciance_assesment.Models;

namespace tecciance_assesment.Services;

public interface IReservationService
{
    Task<Reservation> CreateReservation(int productId, string reservationKey, int quantity);
}