using CsvHelper.Configuration.Attributes;
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

        [Name("original_title"), Index(0)]
        public string Title { get; set; }

        [Name("overview"), Index(0)]
        public string Overview { get; set; }

        [Name("budget"), Index(0)]
        public string Budget { get; set; }

        [Name("revenue"), Index(0)]
        public string Revenue { get; set; }

        //[Name("belongs_to_collection"), Index(0)]
        //public List<BelongsToCollection> BelongsToCollection { get; set; }

        //[Name("genres"), Index(0)]
        //public List<Genres> Genres { get; set; }

        [Name("imdb_id"), Index(0)]
        public string ImdbId { get; set; }

        [Name("popularity"), Index(0)]
        public string Popularity { get; set; }

        //[Name("production_companies"), Index(0)]
        //public List<ProductionCompanies> ProductionCompanies { get; set; }

        //[Name("production_countries"), Index(0)]
        //public List<ProductionCountries> ProductionCountries { get; set; }

        [Name("release_date"), Index(0)]
        public DateTime ReleaseDate { get; set; }

        [Name("status"), Index(0)]
        public string Status { get; set; }

        [Name("runtime"), Index(0)]
        public string Runtime { get; set; }

        //[Name("spoken_languages"), Index(0)]
        //public List<SpokenLanguages> SpokenLanguages { get; set; }

        [Name("vote_average"), Index(0)]
        public string GlobalRating { get; set; }

        [Name("vote_count"), Index(0)]
        public string Votes { get; set; }

    }

    //public class BelongsToCollection
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string PosterPath { get; set; }
    //    public string BackdropPath { get; set; }

    //}

    //public class Genres
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //}

    //public class ProductionCompanies
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string LogoPath { get; set; }
    //    public string OriginCountry { get; set; }

    //}

    //public class ProductionCountries
    //{
    //    public int Id { get; set; }
    //    public string Iso_3166_1 { get; set; }
    //    public string Name { get; set; }

    //}

    //public class SpokenLanguages
    //{
    //    public int Id { get; set; }
    //    public string EnglishName { get; set; }
    //    public string Iso_639_1 { get; set; }
    //    public string Name { get; set; }

    //}

}
