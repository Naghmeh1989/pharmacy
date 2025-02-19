using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class PaymentStatusRepository : IPaymentStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public PaymentStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public PaymentStatus Create(PaymentStatus paymentStatus)
        {
            dbContext.PaymentStatuses.Add(paymentStatus);
            dbContext.SaveChanges();
            return paymentStatus;
        }

        public PaymentStatus? Delete(int id)
        {
            var paymentStatus = dbContext.PaymentStatuses.Find(id);
            if (paymentStatus == null) 
            {
                return null;
            }
            dbContext.PaymentStatuses.Remove(paymentStatus);
            dbContext.SaveChanges();
            return paymentStatus;
        }

        public List<PaymentStatus> GetAll()
        {
            return dbContext.PaymentStatuses.ToList();
        }

        public PaymentStatus? GetById(int id)
        {
            return dbContext.PaymentStatuses.Find(id);
        }

        public PaymentStatus? Update(int id, PaymentStatus paymentStatus)
        {
            var existingPaymentStatus = dbContext.PaymentStatuses.Find(id);
            if (existingPaymentStatus == null)
            {
                return null;
            }
            existingPaymentStatus.Status = paymentStatus.Status;
            existingPaymentStatus.CreatedDate = paymentStatus.CreatedDate;
            existingPaymentStatus.ModifiedDate = paymentStatus.ModifiedDate;
            existingPaymentStatus.CreatedBy = paymentStatus.CreatedBy;
            existingPaymentStatus.ModifiedBy = paymentStatus.ModifiedBy;
            dbContext.SaveChanges();
            return existingPaymentStatus;
        }
    }
}
