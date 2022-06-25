using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TMDb.AuthService.Data;
using TMDb.AuthService.Entities;

namespace TMDb.AuthService.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {

        private readonly AspNetIdentityDbContext dbContext;

        public UserController(AspNetIdentityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("getUser/{id}")]
        public IActionResult GetUser(string id)
        {
            try
            {
                var user = dbContext.Users.SingleOrDefault(u => u.Id == id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                var error = $"can't get the user sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpGet("getFullUser/{id}")]
        public IActionResult GetFullUser(string id)
        {
            try
            {
                var user = dbContext.Users.Include(u => u.FavouriteMovies).SingleOrDefault(u => u.Id == id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                var error = $"can't get the user sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpPost("UploadPic")]
        public IActionResult UploadProfilePicture(TMDbUser User)
        {
            try
            {
                var dbUser = dbContext.Users.SingleOrDefault(u => u.Id == User.Id);
                dbUser.ProfileImage = User.ProfileImage;
                dbContext.SaveChanges();
                return Ok("Success");
            }
            catch (Exception ex)
            {
                var error = $"Can't upload picture sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpPost("AddMovieToFavs")]
        public IActionResult AddMovieToFavs(MovieTitle movieTitle)
        {
            try
            {
                var dbUser = dbContext.Users.Include(u => u.FavouriteMovies).SingleOrDefault(u => u.Id == movieTitle.TMDbUserId);
                dbUser.FavouriteMovies.Add(movieTitle);
                dbContext.SaveChanges();
                return Ok("Success");
            }
            catch (Exception ex)
            {
                var error = $"Can't upload picture sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

        [HttpPost("RemoveMovieFromFavs")]
        public IActionResult RemoveMovieFromFavs(MovieTitle movieTitle)
        {
            try
            {
                var dbUser = dbContext.Users.Include(u => u.FavouriteMovies).SingleOrDefault(u => u.Id == movieTitle.TMDbUserId);
                dbUser.FavouriteMovies.Remove(movieTitle);
                dbContext.SaveChanges();
                return Ok("Success");
            }
            catch (Exception ex)
            {
                var error = $"Can't upload picture sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

    }
}
