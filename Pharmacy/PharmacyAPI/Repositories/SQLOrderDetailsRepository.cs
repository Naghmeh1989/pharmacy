using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLOrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLOrderDetailsRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<OrderDetails> GetAll()
        {
            return dbContext.OrderDetails.ToList();
        }
    }
}
