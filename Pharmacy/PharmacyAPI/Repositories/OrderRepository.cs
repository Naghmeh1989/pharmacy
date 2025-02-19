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

        public Order Create(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            return order;
        }

        public Order? Delete(int id)
        {
            var order = dbContext.Orders.Find(id);
            if (order == null) 
            { 
                return null;
            }
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
            return order;
        }

        public List<Order> GetAll()
        {
           return  dbContext.Orders.ToList();
        }

        public Order? GetById(int id)
        {
            return dbContext.Orders.Find(id);
        }

        public Order? Update(int id, Order order)
        {
            var existingOrder = dbContext.Orders.Find(id);
            if (existingOrder == null)
            {
                return null;
            }
            existingOrder.CreatedBy = order.CreatedBy;
            existingOrder.ModifiedBy = order.ModifiedBy;
            existingOrder.CreatedDate = order.CreatedDate;
            existingOrder.ModifiedDate = order.ModifiedDate;
            existingOrder.OrderNumber = order.OrderNumber;
            existingOrder.OrderStatusId = order.OrderStatusId;
            dbContext.SaveChanges();
            return existingOrder;
        }
    }
}
