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

        public OrderDetails Create(OrderDetails orderDetails)
        {
            dbContext.OrderDetails.Add(orderDetails);
            dbContext.SaveChanges();
            return orderDetails;
        }

        public OrderDetails? Delete(int id)
        {
            var orderDetails = dbContext.OrderDetails.Find(id);
            if (orderDetails == null) 
            { 
                return null;
            } 
            dbContext.OrderDetails.Remove(orderDetails);
            dbContext.SaveChanges();
            return orderDetails;
        }

        public List<OrderDetails> GetAll()
        {
            return dbContext.OrderDetails.ToList();
        }

        public OrderDetails? GetById(int id)
        {
            return dbContext.OrderDetails.Find(id);
        }

        public OrderDetails? Update(int id, OrderDetails orderDetails)
        {
            var existingOrderDetails = dbContext.OrderDetails.Find(id);
            if (existingOrderDetails == null)
            {
                return null;
            }
            existingOrderDetails.CreatedDate = orderDetails.CreatedDate;    
            existingOrderDetails.ModifiedDate = orderDetails.ModifiedDate;
            existingOrderDetails.CreatedBy = orderDetails.CreatedBy;
            existingOrderDetails.ModifiedBy = orderDetails.ModifiedBy;
            existingOrderDetails.OrderId = orderDetails.OrderId;
            existingOrderDetails.DeliveryCharge = orderDetails.DeliveryCharge;      
            existingOrderDetails.DeliveryStatusId = orderDetails.DeliveryStatusId;
            existingOrderDetails.ProductId = orderDetails.ProductId;
            existingOrderDetails.PaymentId = orderDetails.PaymentId;
            existingOrderDetails.Quantity = orderDetails.Quantity;
            existingOrderDetails.ProductPriceAtOrderTime = orderDetails.ProductPriceAtOrderTime;

            dbContext.SaveChanges();
            return existingOrderDetails;
        }
    }
}
