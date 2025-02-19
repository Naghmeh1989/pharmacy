using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IDeliveryStatusRepository
    {
        List<DeliveryStatus> GetAll();
        DeliveryStatus? GetById(int id);
        DeliveryStatus Create(DeliveryStatus deliveryStatus);
        DeliveryStatus? Delete(int id);
        DeliveryStatus? Update(int id,DeliveryStatus deliveryStatus);
    }
}
