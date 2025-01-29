using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly PharmacyDbContext dbContext;

        public TransactionRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Transaction> GetAll()
        {
            return dbContext.Transactions.ToList();
        }
    }
}
