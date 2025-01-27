using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLPaymentRepository : IPaymentRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLPaymentRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Payment> GetAll()
        {
            return dbContext.Payments.ToList();
        }
    }
}
