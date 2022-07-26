using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Presenters
{
    internal class IndexPresenter
    {
        // Movie Object Lists
        private List<MovieModel> _highestRated { get; set; }
        private List<MovieModel> _latestReleases { get; set; }
        private List<MovieModel> _upAndComing { get; set; }

        private IIndexView _indexView;

        public IndexPresenter(IIndexView indexView)
        {
            _indexView = indexView;
        }

        internal async void GetMoviesAsync()
        {
            var apiUrl = Program.Configuration["AppDataApiUri"];
            HttpClient http = new HttpClient();
            _highestRated = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/highestRatedLastYear");
            _latestReleases = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/latestReleases");
            _upAndComing = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/upAndComing");

        }
    }
}
