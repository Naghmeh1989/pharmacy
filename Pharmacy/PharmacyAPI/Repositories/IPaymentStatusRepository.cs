using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IPaymentStatusRepository
    {
        List<PaymentStatus> GetAll();
        PaymentStatus? GetById(int id);
        PaymentStatus Create(PaymentStatus paymentStatus);
        PaymentStatus? Delete(int id);
        PaymentStatus? Update(int id,PaymentStatus paymentStatus);
    }
}
