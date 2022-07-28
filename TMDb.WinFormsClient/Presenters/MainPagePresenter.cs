using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Windows.Forms;
using TMDb.WinFormsClient.Views;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Services;

namespace TMDb.WinFormsClient.Presenters
{
    internal class MainPagePresenter
    {

        // Movie Object Lists
        private List<MovieModel> _highestRated { get; set; }
        private List<MovieModel> _latestReleases { get; set; }
        private List<MovieModel> _upAndComing { get; set; }

        private IMainPageView _mainPageView;

        public MainPagePresenter(IMainPageView mainPage)
        {
            _mainPageView = mainPage;
        }

        public async void GetMoviesAsync()
        {
            var apiUrl = Config.ApiUrl;
            HttpClient http = new HttpClient();
            _highestRated = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/highestRatedLastYear");
            _latestReleases = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/latestReleases");
            _upAndComing = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/upAndComing");

            PopulateDataGridViews();

        }

        public void GoToShowMovie(DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            var idColumnIndex = dataGrid.CurrentCell.ColumnIndex - 1;
            var movieId = dataGrid.Rows[e.RowIndex].Cells[idColumnIndex].Value;

            _mainPageView.IndexView.ShowOnlyShowMovie(movieId.ToString());

        }


        #region Populating and Customizing DataGridViews
        private void PopulateDataGridViews()
        {
            BindingSource highestRatedSource = new BindingSource();
            highestRatedSource.DataSource = _highestRated.Select(m => new { m.Id, m.Title });
            _mainPageView.HighestRatedMovies.DataSource = highestRatedSource;
            _mainPageView.HighestRatedMovies.Columns[0].Visible = false;

            BindingSource LatestReleasesSource = new BindingSource();
            LatestReleasesSource.DataSource = _latestReleases.Select(m => new { m.Id, m.Title });
            _mainPageView.LatestReleasesMovies.DataSource = LatestReleasesSource;
            _mainPageView.LatestReleasesMovies.Columns[0].Visible = false;


            BindingSource UpandComingSource = new BindingSource();
            UpandComingSource.DataSource = _upAndComing.Select(m => new { m.Id, m.Title });
            _mainPageView.UpandComingMovies.DataSource = UpandComingSource;
            _mainPageView.UpandComingMovies.Columns[0].Visible = false;
        }

        #endregion

    }
}
