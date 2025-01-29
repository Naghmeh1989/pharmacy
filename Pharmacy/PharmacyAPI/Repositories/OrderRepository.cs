using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PharmacyDbContext dbContext;

        public OrderRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Order> GetAll()
        {
           return  dbContext.Orders.ToList();
        }
    }
}
