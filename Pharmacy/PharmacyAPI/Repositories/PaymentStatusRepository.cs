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
        public List<PaymentStatus> GetAll()
        {
            return dbContext.PaymentStatuses.ToList();
        }
    }
}
