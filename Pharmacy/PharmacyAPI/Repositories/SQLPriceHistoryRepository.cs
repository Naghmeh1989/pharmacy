using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLPriceHistoryRepository : IPriceHistoryRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLPriceHistoryRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<PriceHistory> GetAll()
        {
            return dbContext.PriceHistories.ToList();
        }
    }
}
