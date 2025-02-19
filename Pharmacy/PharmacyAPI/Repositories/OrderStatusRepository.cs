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

        public OrderStatus Create(OrderStatus orderStatus)
        {
            dbContext.OrderStatuses.Add(orderStatus);
            dbContext.SaveChanges();
            return orderStatus;
        }

        public OrderStatus? Delete(int id)
        {
            var orderStatus = dbContext.OrderStatuses.Find(id);
            if (orderStatus == null)
            { 
                return null;
            }
            dbContext.OrderStatuses.Remove(orderStatus);
            dbContext.SaveChanges();
            return orderStatus;
        }

        public List<OrderStatus> GetAll()
        {
            return dbContext.OrderStatuses.ToList();
        }

        public OrderStatus? GetById(int id)
        {
            return dbContext.OrderStatuses.Find(id);
        }

        public OrderStatus? Update(int id, OrderStatus orderStatus)
        {
            var existingOrderStatus = dbContext.OrderStatuses.Find(id);
            if (existingOrderStatus == null)
            {
                return null;
            }
            existingOrderStatus.ModifiedBy = orderStatus.ModifiedBy;
            existingOrderStatus.ModifiedDate = orderStatus.ModifiedDate;
            existingOrderStatus.Status = orderStatus.Status;
            existingOrderStatus.CreatedBy = orderStatus.CreatedBy;
            existingOrderStatus.CreatedDate = orderStatus.CreatedDate;  
            dbContext.SaveChanges();
            return existingOrderStatus;
        }
    }
}
