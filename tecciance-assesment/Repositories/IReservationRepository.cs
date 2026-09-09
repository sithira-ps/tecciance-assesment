using tecciance_assesment.Models;

namespace tecciance_assesment.Repositories;

public interface IReservationRepository
{
    Task<Reservation> CreateReservation(int productId, string reservationKey, int quantity);
}