using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IOrderDetailsRepository
    {
        List<OrderDetails> GetAll();
        OrderDetails? GetById(int id);
        OrderDetails Create(OrderDetails orderDetails);
        OrderDetails? Delete(int id);
        OrderDetails? Update(int id,OrderDetails orderDetails);
    }
}
