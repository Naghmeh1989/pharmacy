using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class TransactionStatusRepository : ITransactionStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public TransactionStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<TransactionStatus> GetAll()
        {
            return dbContext.TransactionStatuses.ToList();
        }
    }
}
