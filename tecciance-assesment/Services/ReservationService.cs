using tecciance_assesment.Models;
using tecciance_assesment.Repositories;

namespace tecciance_assesment.Services;

public class ReservationService : IReservationService
{
    private IReservationRepository _reservationRepository;

    public ReservationService(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public async Task<Reservation> CreateReservation(int productId, string reservationKey, int quantity)
    {
        var reservation = await _reservationRepository.CreateReservation(productId, reservationKey, quantity);
        return reservation;
    }
}