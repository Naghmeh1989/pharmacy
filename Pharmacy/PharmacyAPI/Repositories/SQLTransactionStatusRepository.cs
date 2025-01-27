using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLTransactionStatusRepository : ITransactionStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLTransactionStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<TransactionStatus> GetAll()
        {
            return dbContext.TransactionStatuses.ToList();
        }
    }
}
