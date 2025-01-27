using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class SQLDeliveryStatusRepository : IDeliveryStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public SQLDeliveryStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<DeliveryStatus> GetAll()
        {
           return dbContext.DeliveryStatuses.ToList();
        }
    }
}
