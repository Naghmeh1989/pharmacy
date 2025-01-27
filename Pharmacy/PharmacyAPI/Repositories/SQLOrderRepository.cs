using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLOrderRepository : IOrderRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLOrderRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Order> GetAll()
        {
           return  dbContext.Orders.ToList();
        }
    }
}
