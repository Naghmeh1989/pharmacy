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
        public List<Payment> GetAll()
        {
            return dbContext.Payments.ToList();
        }
    }
}
