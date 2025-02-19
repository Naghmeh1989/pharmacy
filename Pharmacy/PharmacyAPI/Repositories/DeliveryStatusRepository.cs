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

        public DeliveryStatus Create(DeliveryStatus deliveryStatus)
        {
            dbContext.DeliveryStatuses.Add(deliveryStatus);
            dbContext.SaveChanges();
            return deliveryStatus;
        }

        public DeliveryStatus? Delete(int id)
        {
            var deliveryStatus = dbContext.DeliveryStatuses.Find(id);
            if (deliveryStatus == null) 
            {
                return null;
            }
            dbContext.DeliveryStatuses.Remove(deliveryStatus);
            dbContext.SaveChanges();
            return deliveryStatus;
        }

        public List<DeliveryStatus> GetAll()
        {
           return dbContext.DeliveryStatuses.ToList();
        }

        public DeliveryStatus? GetById(int id)
        {
            return dbContext.DeliveryStatuses.Find(id);
        }

        public DeliveryStatus? Update(int id, DeliveryStatus deliveryStatus)
        {
            var existingDeliveryStatus = dbContext.DeliveryStatuses.Find(id);
            if (existingDeliveryStatus == null)
            {
                return null;
            }
            existingDeliveryStatus.Status = deliveryStatus.Status;
            existingDeliveryStatus.CreatedDate = deliveryStatus.CreatedDate;
            existingDeliveryStatus.CreatedBy = deliveryStatus.CreatedBy;
            existingDeliveryStatus.ModifiedDate = deliveryStatus.ModifiedDate;
            existingDeliveryStatus.ModifiedBy = deliveryStatus.ModifiedBy;
            dbContext.SaveChanges();
            return existingDeliveryStatus;
        }
    }
}
