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
        // GET: api/<AccountController>
        [HttpGet]
        public ActionResult<List<Account>> Get()
        {
            return _accountService.GetAccounts();
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public ActionResult<Account> Get(string id)
        {
            var account = _accountService.GetAccount(id);
            if (account == null)
            {
                return NotFound($"Account with Id = {id} not found");
            }
            return account;
        }

        // POST api/<AccountController>
        [HttpPost]
        public ActionResult<Account> Post([FromBody] Account account)
        {
            _accountService.CreateAccount(account);
            return CreatedAtAction(nameof(Get), new { id = account.Id }, account);
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Account account)
        {
            var exitingAccount = _accountService.GetAccount(id);
            if (exitingAccount == null)
            {
                return NotFound($"Account with Id = {id} not found");
            }
            _accountService.UpdateAccount(id, account);
            return NoContent();
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var account = _accountService.GetAccount(id);
            if (account == null)
            {
                return NotFound($"Order with Id ={id} not found");
            }
            _accountService.DeleteAccount(account.Id);
            return Ok($"Account with Id = {id} deleted");
        }

        // CheckOut api/<AccountController>/5
      /*  [HttpGet(Name = "CheckOut")]
        public ActionResult CheckOut(string password,string id)
        {
            if(_accountService.GetAccount(id).Password.Equals(id))
            {

                return Ok();

            }
            return NoContent();
        }*/
    }
}
