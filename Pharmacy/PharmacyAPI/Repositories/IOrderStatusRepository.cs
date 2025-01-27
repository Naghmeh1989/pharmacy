using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IOrderStatusRepository
    {
        List<OrderStatus> GetAll();
    }
}
