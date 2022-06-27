using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using TMDb.AppDataAPI.Models;
using TMDb.DataAccess.Data;
using TMDb.DataAccess.Entities;

namespace TMDb.AppDataAPI.Controllers
{

    [Route("home")]
    [ApiController]
    public class IndexController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMemoryCache MemoryCache;
        private readonly HttpClient Http;
        private readonly IConfiguration Configuration;

        public IndexController(ApplicationDbContext _dbContext, IMemoryCache _memoryCache, HttpClient _http, IConfiguration _Configuration)
        {
            dbContext = _dbContext;
            MemoryCache = _memoryCache;
            Http = _http;
            Configuration = _Configuration;

        }


        [HttpGet("{movieRequest}")]
        public async Task<IActionResult> GetMoviesAsync(string movieRequest)
        {
            try
            {
                string cacheKey = movieRequest;

                List<MovieModel> movieList;

                if (!MemoryCache.TryGetValue(cacheKey, out movieList))
                {

                    List<Movie> movies;

                    switch (movieRequest)
                    {
                        case "highestRatedLastYear":
                            movies = await dbContext.Movies.OrderByDescending(x => x.GlobalRating).Where(m => m.ReleaseDate.Year == 2016).Take(20).ToListAsync();
                            movieList = await GetMoviePosterPaths(movies);
                            break;

                        case "latestReleases":
                            movies = await dbContext.Movies.OrderByDescending(x => x.ReleaseDate).Where(m => m.Status == "Released").Take(20).ToListAsync();
                            movieList = await GetMoviePosterPaths(movies);
                            break;

                        case "upAndComing":
                            movies = await dbContext.Movies.OrderByDescending(x => x.ReleaseDate).Where(m => m.Status != "Released").Take(20).ToListAsync();
                            movieList = await GetMoviePosterPaths(movies);
                            break;
                    }
                    

                    var cacheExpiryOptions = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTime.Now.AddDays(1),
                        Priority = CacheItemPriority.Normal,
                        SlidingExpiration = TimeSpan.FromMinutes(30)
                    };

                    MemoryCache.Set(cacheKey, movieList, cacheExpiryOptions);
                }


                return Ok(movieList);

            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }

        }

        private async Task<List<MovieModel>> GetMoviePosterPaths(List<Movie> movies)
        {

            List<MovieModel> movieList = new List<MovieModel>();

            foreach (var movie in movies)
            {
                string moviePosterPath;
                var result = await Http.GetAsync($"https://api.themoviedb.org/3/movie/{movie.ImdbId}?api_key={Configuration["externalTmdbApiKey"]}");
                if (result.IsSuccessStatusCode)
                {
                    var Content = await result.Content.ReadFromJsonAsync<JsonMovie>();
                    moviePosterPath = Content.poster_path;
                }
                else
                {
                    moviePosterPath = null;
                }

                movieList.Add(new MovieModel()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Overview = movie.Overview,
                    Budget = movie.Budget,
                    Revenue = movie.Revenue,
                    ImdbId = movie.ImdbId,
                    Popularity = movie.Popularity,
                    PosterPath = moviePosterPath,
                    ReleaseDate = movie.ReleaseDate,
                    Status = movie.Status,
                    Runtime = movie.Runtime,
                    GlobalRating = movie.GlobalRating,
                    Votes = movie.Votes

                });
            }

            return movieList;
        }


    }
}
