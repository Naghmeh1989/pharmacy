using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLTransactionRepository : ITransactionRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLTransactionRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Transaction> GetAll()
        {
            return dbContext.Transactions.ToList();
        }
    }
}
