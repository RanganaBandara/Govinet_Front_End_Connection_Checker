using Govinet_Front_End_Connection_Checker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Govinet_Front_End_Connection_Checker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        private readonly CheckDbContext _context;
        public CheckController(CheckDbContext context)
        {
                _context = context;
        }
        // GET: api/<CheckController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data= await _context.Chekers.ToListAsync();
            var response = (
                data
                );

            return Ok( response );
        }


        // GET api/<CheckController>/5
        [HttpGet("{crop}")]
        public async Task<IActionResult> getbycrop([FromRoute ]string crop)
        {
            var message= await _context.Chekers.FindAsync(crop);
            var reposnse = (
              
                message
                
                );
            return Ok(reposnse);
           
        }

        // POST api/<CheckController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Check chek)
        {
            await _context.Chekers.AddAsync(chek);
            _context.SaveChanges();
            return Ok("opertion success");
        }

        // PUT api/<CheckController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CheckController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
