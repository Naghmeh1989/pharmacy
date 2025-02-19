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

        public PriceHistory Create(PriceHistory priceHistory)
        {
            dbContext.PriceHistories.Add(priceHistory);
            dbContext.SaveChanges();
            return priceHistory;
        }

        public PriceHistory? Delete(int id)
        {
            var prieHistory = dbContext.PriceHistories.Find(id);
            if (prieHistory == null) 
            {
                return null;
            }
            dbContext.PriceHistories.Remove(prieHistory);
            dbContext.SaveChanges();
            return prieHistory;
        }

        public List<PriceHistory> GetAll()
        {
            return dbContext.PriceHistories.ToList();
        }

        public PriceHistory? GetById(int id)
        {
            return dbContext.PriceHistories.Find(id);
        }

        public PriceHistory? Update(int id, PriceHistory priceHistory)
        {
            var existingPriceHistory = dbContext.PriceHistories.Find(id);
            if (existingPriceHistory == null)
            {
                return null;
            }
            existingPriceHistory.CreatedBy = priceHistory.CreatedBy;
            existingPriceHistory.CreatedDate = priceHistory.CreatedDate;
            existingPriceHistory.ModifiedBy = priceHistory.ModifiedBy;
            existingPriceHistory.ModifiedDate = priceHistory.ModifiedDate;
            existingPriceHistory.StartDate = priceHistory.StartDate;
            existingPriceHistory.EndDate = priceHistory.EndDate;
            existingPriceHistory.OldPrice = priceHistory.OldPrice;
            existingPriceHistory.ProductId = priceHistory.ProductId;
            dbContext.SaveChanges();
            return existingPriceHistory;
        }
    }
}
