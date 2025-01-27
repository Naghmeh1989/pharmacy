using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
    }
}
