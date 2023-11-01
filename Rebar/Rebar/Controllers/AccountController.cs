using Microsoft.AspNetCore.Mvc;
using Rebar.Model;
using Rebar.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rebar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return _accountService.GetOrders();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(string id)
        {
            var order = _accountService.GetOrder(id);
            if (order == null)
            {
                return NotFound($"Order with Id = {id} not found");
            }
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult<Order> Post([FromBody] Order order)
        {
            _accountService.CreateOrder(order);
            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Order order)
        {
            var exitingOrder = _accountService.GetOrder(id);
            if (exitingOrder == null)
            {
                return NotFound($"Order with Id = {id} not found");
            }
            _accountService.UpdateOrder(id, order);
            return NoContent();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var order = _accountService.GetOrder(id);
            if (order == null)
            {
                return NotFound($"Order with Id ={id} not found");
            }
            _accountService.DeleteOrder(order.Id);
            return Ok($"Order with Id = {id} deleted");
        }
    }
}
