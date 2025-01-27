using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IPaymentStatusRepository
    {
        List<PaymentStatus> GetAll();
    }
}
