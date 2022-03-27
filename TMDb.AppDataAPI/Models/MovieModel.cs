namespace TMDb.AppDataAPI.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public int Budget { get; set; }
        public int Revenue { get; set; }
        public Object BelongsToCollection { get; set; }
        public Object[] Genres { get; set; }
        public string ImdbId { get; set; }
        public Decimal Popularity { get; set; }
        public string PosterPath { get; set; }
        public Object[] ProductionCompanies { get; set; }
        public Object[] ProductionCountries { get; set; }
        public string ReleaseDate { get; set; }
        public string Status { get; set; }
        public int Runtime { get; set; }
        public Object[] SpokenLanguages { get; set; }
        public Decimal GlobalRating { get; set; }

    }
}
