// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using Microsoft.AspNetCore.Identity;

namespace TMDb.BlazorClient.Models;

public class TMDbUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Country { get; set; }
    public int Age { get; set; }
    public List<MovieTitle> FavouriteMovies { get; set; }
    public DateTime CreatedDate { get; set; }

}

public class MovieTitle
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int MovieId { get; set; }
}
