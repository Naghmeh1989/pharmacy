using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IPaymentRepository
    {
        List<Payment> GetAll();
    }
}
