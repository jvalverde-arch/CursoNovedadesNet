using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Repository;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderController(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Orders = _OrderRepository.GetOrders();
            return new OkObjectResult(Orders);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Order = _OrderRepository.GetOrderById(id);
            return new OkObjectResult(Order);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Order order)
        {
            using (var scope = new TransactionScope())
            {
                _OrderRepository.InsertOrder(order);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Order order)
        {
            if (order != null)
            {
                using (var scope = new TransactionScope())
                {
                    _OrderRepository.UpdateOrder(order);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _OrderRepository.DeleteOrder(id);
            return new OkResult();
        }
    }
}
