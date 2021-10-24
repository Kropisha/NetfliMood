using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NetfliMood.Data;
using NetfliMood.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetfliMood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NetfliMoodController : ControllerBase
    {

        private readonly ILogger<NetfliMoodController> _logger;
        private readonly NetfliMoodContext _context;

        public NetfliMoodController(ILogger<NetfliMoodController> logger, NetfliMoodContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie is null) NotFound();

            return movie;            
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> AddMovie(Movie movie, int genreId)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            _context.MovieGenreRelations.Add(new MovieGenreRelation { GenreId = genreId, MovieId = movie.Id });
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> EditMovie(int id, Movie movie)
        {
            if (id != movie.Id) return BadRequest();

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie is null) NotFound();

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        private bool MovieExists(int id)
        {
            return true;
        }
    }
}
