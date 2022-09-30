using Microsoft.EntityFrameworkCore;
using ProductService.DBContext;
using ProductService.Models;

namespace ProductService.Repository
{
    public class OrderRepository: IOrderRepository
    {
        private OrderContext _dbContext;

        public OrderRepository(OrderContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteOrder(int orderId)
        {
            var order = _dbContext.Orders.Find(orderId);

            if (order != null)
                _dbContext.Orders.Remove(order);
            Save();
        }

        public Order GetOrderById(int orderId)
        {
            return _dbContext.Orders.Find(orderId);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public void InsertOrder(Order order)
        {
            _dbContext.Add(order);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _dbContext.Entry(order).State = EntityState.Modified;
            Save();
        }

    }
}
