using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly PharmacyDbContext dbContext;

        public OrderDetailsRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<OrderDetails> GetAll()
        {
            return dbContext.OrderDetails.ToList();
        }
    }
}
