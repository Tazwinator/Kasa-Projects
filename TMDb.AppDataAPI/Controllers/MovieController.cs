using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMDb.DataAccess.Data;

namespace TMDb.AppDataAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class MovieController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public MovieController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            try
            {
                var movie = await dbContext.Movies.Where(x => x.Id == id)
                    //.Include(b => b.BelongsToCollection)
                    //.Include(g => g.Genres)
                    //.Include(pcom => pcom.ProductionCompanies)
                    //.Include(pcountries => pcountries.ProductionCountries)
                    //.Include(sl => sl.SpokenLanguages)
                    .FirstOrDefaultAsync();

                //MovieModel movieModel = new MovieModel()
                //{
                //    Title = movie.Title,
                //    Overview = movie.Overview,
                //    Budget = movie.Budget,
                //    Revenue = movie.Revenue,
                //    ImdbId = movie.ImdbId,
                //    Popularity = movie.Popularity,
                //    ReleaseDate = movie.ReleaseDate,
                //    Status = movie.Status,
                //    Runtime = movie.Runtime,
                //    GlobalRating = movie.GlobalRating,
                //    Votes = movie.Votes,
                //};

                //movieModel.BelongsToCollection = csvJsonParser.GetModelObject<List<BelongsToCollectionModel>>(movie.BelongsToCollection[0].Name);
                //movieModel.Genres = csvJsonParser.GetModelObject<List<GenresModel>>(movie.Genres[0].Name);
                //movieModel.ProductionCompanies = csvJsonParser.GetModelObject<List<ProductionCompaniesModel>>(movie.ProductionCompanies[0].Name);
                //movieModel.ProductionCountries = csvJsonParser.GetModelObject<List<ProductionCountriesModel>>(movie.ProductionCountries[0].Name);
                //movieModel.SpokenLanguages = csvJsonParser.GetModelObject<List<SpokenLanguagesModel>>(movie.SpokenLanguages[0].Name);

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
