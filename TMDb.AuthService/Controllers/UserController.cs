using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDb.AuthService.Data;
using TMDb.AuthService.Models;

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

        [HttpGet("getSingleUser/{id}")]
        public IActionResult GetSingleUser(string id)
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

    }
}
