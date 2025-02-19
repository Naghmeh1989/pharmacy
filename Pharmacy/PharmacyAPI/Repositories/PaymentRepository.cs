using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PharmacyDbContext dbContext;

        public PaymentRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Payment Create(Payment payment)
        {
            dbContext.Payments.Add(payment);
            dbContext.SaveChanges();
            return payment;
        }

        public Payment? Delete(int id)
        {
            var payment = dbContext.Payments.Find(id);
            if (payment == null)
            {
                return null;
            }
            dbContext.Payments.Remove(payment);
            dbContext.SaveChanges();
            return payment;
        }

        public List<Payment> GetAll()
        {
            return dbContext.Payments.ToList();
        }

        public Payment? GetById(int id)
        {
            return dbContext.Payments.Find(id);
        }

        public Payment? Update(int id, Payment payment)
        {
            var existingPayment = dbContext.Payments.Find(id);
            if (existingPayment == null)
            {
                return null;
            }
            existingPayment.CreatedBy = payment.CreatedBy;
            existingPayment.ModifiedBy = payment.ModifiedBy;
            existingPayment.ModifiedDate = payment.ModifiedDate;
            existingPayment.CreatedDate = payment.CreatedDate;
            existingPayment.Method = payment.Method;
            existingPayment.PaymentAmount = payment.PaymentAmount;
            existingPayment.PaymentStatusId = payment.PaymentStatusId;
            existingPayment.TransactionId = payment.TransactionId;
            dbContext.SaveChanges();
            return existingPayment;
        }
    }
}
