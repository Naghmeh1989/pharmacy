using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class DeliveryStatusRepository : IDeliveryStatusRepository
    {
        private readonly PharmacyDbContext dbContext;

        public DeliveryStatusRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<DeliveryStatus> GetAll()
        {
           return dbContext.DeliveryStatuses.ToList();
        }
    }
}
