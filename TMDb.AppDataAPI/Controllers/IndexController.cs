using Microsoft.AspNetCore.Mvc;
using TMDb.DataAccess.Data;

namespace TMDb.AppDataAPI.Controllers
{

    [Route("home")]
    [ApiController]
    public class IndexController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public IndexController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("highestRatedLastYear")]
        public IActionResult GetFeaturedMovies()
        {
            try
            {
                // By popularity
                var movies = dbContext.Movies.OrderByDescending(x => x.GlobalRating).Where(m => m.ReleaseDate.Year == 2016).Take(20).ToList();
                return Ok(movies);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpGet("latestReleases")]
        public IActionResult GetLatestMovies()
        {
            try
            {
                // By release date
                var movies = dbContext.Movies.OrderByDescending(x => x.ReleaseDate).Where(m => m.Status == "Released").Take(20).ToList();
                return Ok(movies);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpGet("upAndComing")]
        public IActionResult GetUpAndComingMovies()
        {
            try
            {
                // By release date
                var movies = dbContext.Movies.OrderByDescending(x => x.ReleaseDate).Where(m => m.Status != "Released").Take(20).ToList();
                return Ok(movies);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }
    }
}
