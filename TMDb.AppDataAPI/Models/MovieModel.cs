namespace TMDb.AppDataAPI.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Budget { get; set; }
        public string Revenue { get; set; }
        //public List<BelongsToCollectionModel> BelongsToCollection { get; set; }
        //public List<GenresModel> Genres { get; set; }
        public string ImdbId { get; set; }
        public string Popularity { get; set; }
        //public List<ProductionCompaniesModel> ProductionCompanies { get; set; }
        //public List<ProductionCountriesModel> ProductionCountries { get; set; }
        public string ReleaseDate { get; set; }
        public string Status { get; set; }
        public string Runtime { get; set; }
        //public List<SpokenLanguagesModel> SpokenLanguages { get; set; }
        public string GlobalRating { get; set; }
        public string Votes { get; set; }

    }

    //public class BelongsToCollectionModel
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string PosterPath { get; set; }
    //    public string BackdropPath { get; set; }

    //}

    //public class GenresModel
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //}

    //public class ProductionCompaniesModel
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string LogoPath { get; set; }
    //    public string OriginCountry { get; set; }

    //}

    //public class ProductionCountriesModel
    //{
    //    public int Id { get; set; }
    //    public string Iso_3166_1 { get; set; }
    //    public string Name { get; set; }

    //}

    //public class SpokenLanguagesModel
    //{
    //    public int Id { get; set; }
    //    public string EnglishName { get; set; }
    //    public string Iso_639_1 { get; set; }
    //    public string Name { get; set; }

    //}
}

