using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Services;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Presenters
{
    internal class ShowMoviePresenter
    {
        private IShowMovieView _showMovieView { get; set; } 
        public ShowMoviePresenter(IShowMovieView showMovieView)
        {
            _showMovieView = showMovieView;
        }

        internal async void GetMovieAsync(string movieId)
        {
            if (!(movieId == "0"))
            {
                string ApiUrl = Config.ApiUrl;
                HttpClient http = new HttpClient();
                _showMovieView.Movie = await http.GetFromJsonAsync<MovieModel>($"{ApiUrl}/movie/{movieId}");
                try
                {
                    JsonMovie jsonMovie = await http
                        .GetFromJsonAsync<JsonMovie>(
                            $"https://api.themoviedb.org/3/movie/{_showMovieView.Movie.ImdbId}?api_key={Config.ApiKey}"
                        );
                    _showMovieView.Movie.PosterPath = jsonMovie.poster_path;
                }
                catch
                {
                    MessageBox.Show("Unfortunately, this movie does not have a poster.");
                }
                _showMovieView.Movie.Budget = string.Format("{0:n}", Convert.ToInt32(_showMovieView.Movie.Budget));
                _showMovieView.Movie.Revenue = string.Format("{0:n}", Convert.ToInt64(_showMovieView.Movie.Revenue));
                _showMovieView.Movie.Runtime = string.Format("{0:n0}", Convert.ToDecimal(_showMovieView.Movie.Runtime));

                _showMovieView.DisplayData();
            }
            else
            {
                return;
            }
        }
    }
}
