using Microsoft.AspNetCore.Mvc;
using TMDb.AppDataAPI.Models;
using TMDb.DataAccess.Data;
using TMDb.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

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
                var movie = dbContext.Movies.Take(20).ToList();
                return Ok(movie);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }



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

        [HttpGet("seed")]
        public async Task<IActionResult> SeedDb()
        {
            try
            {
                List<object> records;
                List<Movie> MovieList = new();
                using (var reader = new StreamReader("Resources/movies_metadata.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<dynamic>().ToList();
                    foreach (object record in records)
                    {
                        var title = ((dynamic)record).original_title;
                        var overview = ((dynamic)record).overview;
                        var budget = ((dynamic)record).budget;
                        var revenue = ((dynamic)record).revenue;
                        //var belongsToCollection = ((dynamic)record).belongs_to_collection;
                        //var genres = ((dynamic)record).genres;
                        var imdbId = ((dynamic)record).imdb_id;
                        var popularity = ((dynamic)record).popularity;
                        var posterPath = ((dynamic)record).poster_path;
                        //var productionCompanies = ((dynamic)record).production_companies;
                        //var productionCountries = ((dynamic)record).production_countries;
                        var releaseDate = ((dynamic)record).release_date;
                        var status = ((dynamic)record).status;
                        var runtime = ((dynamic)record).runtime;
                        //var spokenLanguagese = ((dynamic)record).spoken_languages;
                        var globalRating = ((dynamic)record).vote_average;
                        var votes = ((dynamic)record).vote_count;

                        //List<BelongsToCollection> belongsToCollection1 = new List<BelongsToCollection>();
                        //belongsToCollection1.Add(new BelongsToCollection() { Name = ((dynamic)belongsToCollection) });

                        //List<Genres> genres1 = new List<Genres>();
                        //genres1.Add(new Genres() { Name = ((dynamic)genres) });

                        //List<ProductionCompanies> productionCompanies1 = new List<ProductionCompanies>();
                        //productionCompanies1.Add(new ProductionCompanies() { Name = ((dynamic)productionCompanies) });

                        //List<ProductionCountries> productionCountries1 = new List<ProductionCountries>();
                        //productionCountries1.Add(new ProductionCountries() { Name = ((dynamic)productionCountries) });

                        //List<SpokenLanguages> spokenLanguagese1 = new List<SpokenLanguages>();
                        //spokenLanguagese1.Add(new SpokenLanguages() { Name = ((dynamic)spokenLanguagese) });

                        MovieList.Add(new Movie()
                        {
                            Title = title,
                            Overview = overview,
                            Budget = budget,
                            Revenue = revenue,
                            //BelongsToCollection = belongsToCollection1,
                            //Genres = genres1,
                            ImdbId = imdbId,
                            Popularity = popularity,
                            //ProductionCompanies = productionCompanies1,
                            //ProductionCountries = productionCountries1,
                            ReleaseDate = releaseDate,
                            Status = status,
                            Runtime = runtime,
                            //SpokenLanguages = spokenLanguagese1,
                            GlobalRating = globalRating,
                            Votes = votes
                        });
                    }

                    records.Clear();

                    foreach (Movie movie in MovieList)
                    {
                        await dbContext.Movies.AddAsync(movie);
                    }

                    MovieList.Clear();

                    await dbContext.SaveChangesAsync();

                    return Ok(MovieList.FirstOrDefault());
                }
                
                
                
            }
            catch (Exception ex)
            {
                string exString = $"{ex.Message} {ex.StackTrace}";
                return BadRequest(exString);
            }


        }


        //[HttpGet("testSeed")]
        //public async Task<IActionResult> TestSeedDb()
        //{
        //    try
        //    {
        //        List<object> records;
        //        List<Movie> MovieList = new();
        //        using (var reader = new StreamReader("Resources/movies_metadata.csv"))
        //        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //        {
        //            records = csv.GetRecords<dynamic>().ToList();
        //            foreach (object record in records)
        //            {
        //                var title = ((dynamic)record).original_title;
        //                var overview = ((dynamic)record).overview;
        //                var budget = ((dynamic)record).budget;
        //                var revenue = ((dynamic)record).revenue;
        //                var belongsToCollection = ((dynamic)record).belongs_to_collection;
        //                var genres = ((dynamic)record).genres;
        //                var imdbId = ((dynamic)record).imdb_id;
        //                var popularity = ((dynamic)record).popularity;
        //                var posterPath = ((dynamic)record).poster_path;
        //                var productionCompanies = ((dynamic)record).production_companies;
        //                var productionCountries = ((dynamic)record).production_countries;
        //                var releaseDate = ((dynamic)record).release_date;
        //                var status = ((dynamic)record).status;
        //                var runtime = ((dynamic)record).runtime;
        //                var spokenLanguages = ((dynamic)record).spoken_languages;
        //                var globalRating = ((dynamic)record).vote_average;
        //                var votes = ((dynamic)record).vote_count;


        //                MovieList.Add(new Movie()
        //                {
        //                    Title = title,
        //                    Overview = overview,
        //                    Budget = budget,
        //                    Revenue = revenue,
        //                    BelongsToCollection = csvJsonParser.GetEntityObject<List<BelongsToCollection>>(belongsToCollection),
        //                    Genres = csvJsonParser.GetEntityObject<List<Genres>>(genres),
        //                    ImdbId = imdbId,
        //                    Popularity = popularity,
        //                    PosterPath = posterPath,
        //                    ProductionCompanies = csvJsonParser.GetEntityObject<List<ProductionCompanies>>(productionCompanies),
        //                    ProductionCountries = csvJsonParser.GetEntityObject<List<ProductionCountries>>(productionCountries),
        //                    ReleaseDate = releaseDate,
        //                    Status = status,
        //                    Runtime = runtime,
        //                    SpokenLanguages = csvJsonParser.GetEntityObject<List<SpokenLanguages>>(spokenLanguages),
        //                    GlobalRating = globalRating,
        //                    Votes = votes
        //                });
        //            }

        //            records.Clear();

        //            foreach (Movie movie in MovieList)
        //            {
        //                await dbContext.Movies.AddAsync(movie);
        //            }

        //            MovieList.Clear();

        //            await dbContext.SaveChangesAsync();

        //            return Ok(MovieList.FirstOrDefault());
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        string exString = $"{ex.InnerException} {ex.Source} {ex.Message} {ex.StackTrace}";
        //        return BadRequest(exString);
        //    }


        //}

    }
}
