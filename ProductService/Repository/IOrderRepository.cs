using ProductService.Models;

namespace ProductService.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int id);

        void InsertOrder(Order order);

        void UpdateOrder(Order order);

        void DeleteOrder(int id);

        void Save();
    }
}
