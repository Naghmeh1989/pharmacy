using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLOrderStatusRepository : IOrderStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLOrderStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<OrderStatus> GetAll()
        {
            return dbContext.OrderStatuses.ToList();
        }
    }
}
