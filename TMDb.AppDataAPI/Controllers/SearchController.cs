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
    public class SearchController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public SearchController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("{searchQuery}")]
        public IActionResult GetMovie(string searchQuery)
        {
            try
            {

                //var movies = dbContext.Movies.Where(x => x.Id == 1).ToList<Movie>();
                //var movie = movies.FirstOrDefault();
                //return Ok($"Here are your movies: {movie.Title}{movie.Overview}");
                var movie = dbContext.Movies.Where(m => m.Title.Contains(searchQuery)).Take(25).ToList();
                if (movie.Count() > 0)
                {
                    return Ok(movie);
                }
                return Ok(null);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpGet("search-suggestions/{searchQuery}")]
        public IActionResult GetMovieSuggestions(string searchQuery)
        {
            try
            {

                //var movies = dbContext.Movies.Where(x => x.Id == 1).ToList<Movie>();
                //var movie = movies.FirstOrDefault();
                //return Ok($"Here are your movies: {movie.Title}{movie.Overview}");
                var movie = dbContext.Movies.Where(m => m.Title.Contains(searchQuery)).Select(m => new { m.Title, m.Overview }).Take(5).ToList();
                if (movie.Count() > 0)
                {
                    return Ok(movie);
                }
                return Ok(null);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

    }
}
