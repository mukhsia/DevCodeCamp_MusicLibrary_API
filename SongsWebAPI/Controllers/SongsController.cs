using Microsoft.AspNetCore.Mvc;
using SongsWebAPI.Data;
using SongsWebAPI.Models;

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
            var songs = _context.Songs.ToList();
            return Ok(songs);
        }

        // GET By Id: api/Songs/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var song = _context.Songs.Where(s => s.Id == id).SingleOrDefault();
            if(song != null)
            {
                return Ok(song);
            } 
            else
            {
                return NotFound();
            }
        }

        // POST api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);
        }

        // PUT api/Songs/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            var mySong = _context.Songs.Where(s => s.Id == id).SingleOrDefault();
            if(mySong != null)
            {
                mySong.Title = song.Title;
                mySong.Artist = song.Artist;
                mySong.Album = song.Album;
                mySong.ReleaseDate = song.ReleaseDate;
                mySong.Genre = song.Genre;

                _context.Songs.Update(mySong);
                _context.SaveChanges();

                return Ok(mySong);
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/Songs/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Where(s => s.Id == id).SingleOrDefault();
            if (song != null)
            {
                _context.Songs.Remove(song);
                _context.SaveChanges();

                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
