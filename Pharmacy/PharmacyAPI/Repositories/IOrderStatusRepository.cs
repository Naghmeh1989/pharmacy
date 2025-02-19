using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IOrderStatusRepository
    {
        List<OrderStatus> GetAll();
        OrderStatus? GetById(int id);
        OrderStatus Create(OrderStatus orderStatus);
        OrderStatus? Delete(int id);
        OrderStatus? Update(int id,OrderStatus orderStatus);
    }
}
