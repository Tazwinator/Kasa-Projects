using Microsoft.AspNetCore.Mvc;
using TMDb.AppDataAPI.Models;
using TMDb.DataAccess.Data;
using TMDb.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TMDb.AppDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public MoviesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("featured")]
        public IActionResult GetFeaturedMovies()
        {
            try
            {
                // Getting featured movies not yet implemented, sort by popularity
                var movie = dbContext.Movies.Take(5).ToList();
                return Ok(movie);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }



        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            try
            {
                var movie = dbContext.Movies.FindAsync(id);
                return Ok(movie);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
            

            
        }
    }
}
