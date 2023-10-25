using Microsoft.AspNetCore.Mvc;
using SongsWebAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SongsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // ApplicationDbContext and controller for querying MySQL DB
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
            _context.SaveChanges();
        }

        // GET All: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Songs);
        }

        // GET By Id: api/Songs/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Forbid();
        }

        // POST api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Forbid();
        }

        // PUT api/Songs/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Forbid();
        }

        // DELETE api/Songs/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Forbid();
        }
    }
}
