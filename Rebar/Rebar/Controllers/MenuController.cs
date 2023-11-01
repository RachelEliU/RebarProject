using Microsoft.AspNetCore.Mvc;
using Rebar.Model;
using Rebar.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rebar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        // GET: api/<MenuController>
        [HttpGet]
        public ActionResult<List<Shake>> Get()
        {
            return _menuService.GetShakes();
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        public ActionResult<Shake> Get(Guid id)
        {
            var shake = _menuService.GetShake(id);
            if (shake == null)
            {
                return NotFound($"Shake with Id = {id} not found");
            }
            return shake;
        }

        // POST api/<MenuController>
        /* [HttpPost]
         public ActionResult<Shake> Post([FromBody] Shake shake)
         {

             _menuService.CreateShake(shake);
             return CreatedAtAction(nameof(Get), new { id = shake.Id }, shake);
         }*/
        [HttpPost (Name ="Post")]
        public void Post(Shake shake)
        {
             _menuService.CreateShake(shake);
        }


        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Shake shake)
        {
            var exitingOrder = _menuService.GetShake(id);
            if (exitingOrder == null)
            {
                return NotFound($"Shake with Id = {id} not found");
            }
            _menuService.UpdateShake(id, shake);
            return NoContent();
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var shake = _menuService.GetShake(id);
            if (shake == null)
            {
                return NotFound($"Shake with Id ={id} not found");
            }
            _menuService.DeleteShake(shake.Id);
            return Ok($"Shake with Id = {id} deleted");
        }
    }
}
