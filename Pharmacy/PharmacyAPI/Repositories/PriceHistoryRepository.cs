using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class PriceHistoryRepository : IPriceHistoryRepository
    {
        private readonly PharmacyDbContext dbContext;

        public PriceHistoryRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<PriceHistory> GetAll()
        {
            return dbContext.PriceHistories.ToList();
        }
    }
}
