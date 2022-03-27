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
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public MovieController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetMovie()
        {
            try
            {

               

                var movies = dbContext.Movies.Where(x => x.Id == 1).ToList<Movie>();
                var movie = movies.FirstOrDefault();
                return Ok($"Here are your movies: {movie.Title}{movie.Overview}");
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
            

            
        }
    }
}
