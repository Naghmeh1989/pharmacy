using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public OrderStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<OrderStatus> GetAll()
        {
            return dbContext.OrderStatuses.ToList();
        }
    }
}
