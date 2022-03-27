using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDb.DataAccess.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Budget { get; set; }
        public string Revenue { get; set; }
        //public List<BelongsToCollection> BelongsToCollection { get; set; }
        //public List<Genres> Genres { get; set; }
        public string ImdbId { get; set; }
        public string Popularity { get; set; }
        public string PosterPath { get; set; }
        //public List<ProductionCompanies> ProductionCompanies { get; set; }
        //public List<ProductionCountries> ProductionCountries { get; set; }
        public string ReleaseDate { get; set; }
        public string Status { get; set; }
        public string Runtime { get; set; }
        //public List<SpokenLanguages> SpokenLanguages { get; set; }
        public string GlobalRating { get; set; }


    }
}
