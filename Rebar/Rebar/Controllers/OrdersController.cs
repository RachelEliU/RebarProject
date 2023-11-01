using Microsoft.AspNetCore.Mvc;
using Rebar.Model;
using Rebar.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rebar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return _orderService.GetOrders();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(Guid id)
        {
            var order = _orderService.GetOrder(id);
            if(order == null)
            {
                return NotFound($"Order with Id = {id} not found");
            }
            return order;
        }
       
        // POST api/<OrdersController>
        [HttpPost]
         public ActionResult<Order> Post([FromBody] Order order)
          {
              _orderService.CreateOrder(order);
              return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
          }
      /*  [HttpGet("{order}", Name = "Post")]
        public void Post(Order order)
        {
            _orderService.CreateOrder(order);
            // return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }*/

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Order order)
        {
            var exitingOrder = _orderService.GetOrder(id);
            if(exitingOrder == null)
            {
                return NotFound($"Order with Id = {id} not found");
            }
            _orderService.UpdateOrder(id, order);
            return NoContent();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var order = _orderService.GetOrder(id);
            if( order == null)
            {
                return NotFound($"Order with Id ={id} not found");
            }
            _orderService.DeleteOrder(order.Id);
            return Ok($"Order with Id = {id} deleted");
        }
    }
}
