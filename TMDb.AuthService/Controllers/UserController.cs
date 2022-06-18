using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDb.AuthService.Data;

namespace TMDb.AuthService.Controllers
{
    [Route("getUserData")]
    [ApiController]

    public class UserController : ControllerBase
    {

        private readonly AspNetIdentityDbContext dbContext;

        public UserController(AspNetIdentityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("getSingleUser/{id}")]
        public IActionResult GetFeaturedMovies(string id)
        {
            try
            {
                var user = dbContext.Users.SingleOrDefault(u => u.Id == id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                var error = $"No movies found sorry, Exceptions: {ex}";
                return BadRequest(error);
            }
        }

    }
}
