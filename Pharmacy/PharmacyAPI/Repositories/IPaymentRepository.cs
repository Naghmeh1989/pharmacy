using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IPaymentRepository
    {
        List<Payment> GetAll();
        Payment? GetById(int id);
        Payment Create(Payment payment);
        Payment? Delete(int id);
        Payment? Update(int id,Payment payment);
    }
}
