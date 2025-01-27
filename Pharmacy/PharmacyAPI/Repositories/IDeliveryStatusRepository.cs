using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IDeliveryStatusRepository
    {
        List<DeliveryStatus> GetAll();
    }
}
