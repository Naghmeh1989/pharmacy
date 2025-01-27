using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IOrderDetailsRepository
    {
        List<OrderDetails> GetAll();
    }
}
