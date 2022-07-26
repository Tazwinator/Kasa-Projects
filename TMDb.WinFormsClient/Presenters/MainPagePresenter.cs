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

        private IMainPageView _mainPage;

        public MainPagePresenter(IMainPageView mainPage)
        {
            _mainPage = mainPage;
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

        //private EventHandler GoToMovie()
        //{
            
        //}

        #region Populating and Customizing DataGridViews
        private void PopulateDataGridViews()
        {
            _mainPage.HighestRatedMovies.Columns.Add("Name", "Name");
            _mainPage.HighestRatedMovies.RowHeadersVisible = false;
            _mainPage.HighestRatedMovies.ColumnHeadersVisible = false;
            _mainPage.HighestRatedMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _mainPage.HighestRatedMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _mainPage.HighestRatedMovies.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _mainPage.HighestRatedMovies.MultiSelect = false;
            //_mainPage.HighestRatedMovies.SelectionChanged += GoToMovie();
            _highestRated.ForEach(m =>
            {
                _mainPage.HighestRatedMovies.Rows.Add(m.Title);
            });

            _mainPage.LatestReleasesMovies.Columns.Add("Name", "Name");
            _mainPage.LatestReleasesMovies.RowHeadersVisible = false;
            _mainPage.LatestReleasesMovies.ColumnHeadersVisible = false;
            _mainPage.LatestReleasesMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _mainPage.LatestReleasesMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _mainPage.LatestReleasesMovies.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _mainPage.LatestReleasesMovies.MultiSelect = false;
            _latestReleases.ForEach(m =>
            {
                _mainPage.LatestReleasesMovies.Rows.Add(m.Title);
            });

            _mainPage.UpandComingMovies.Columns.Add("Name", "Name");
            _mainPage.UpandComingMovies.RowHeadersVisible = false;
            _mainPage.UpandComingMovies.ColumnHeadersVisible = false;
            _mainPage.UpandComingMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _mainPage.UpandComingMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _mainPage.UpandComingMovies.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _mainPage.UpandComingMovies.MultiSelect = false;
            _upAndComing.ForEach(m =>
            {
                _mainPage.UpandComingMovies.Rows.Add(m.Title);
            });
        }

        #endregion

    }
}
