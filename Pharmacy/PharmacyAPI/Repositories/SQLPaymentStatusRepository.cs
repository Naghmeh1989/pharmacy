using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLPaymentStatusRepository : IPaymentStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLPaymentStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<PaymentStatus> GetAll()
        {
            return dbContext.PaymentStatuses.ToList();
        }
    }
}
