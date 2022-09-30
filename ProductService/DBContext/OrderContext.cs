using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.DBContext
{
    public class OrderContext: DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        public DbSet<Order>? Orders { get; set; }
    }
}
