using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order? GetById(int id);
        Order Create(Order order);
        Order? Delete(int id);
        Order? Update(int id,Order order);
    }
}
