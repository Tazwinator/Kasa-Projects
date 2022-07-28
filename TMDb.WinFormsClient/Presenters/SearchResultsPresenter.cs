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
    internal class SearchResultsPresenter
    {

        private ISearchResultsView _searchResultsView;

        public SearchResultsPresenter(ISearchResultsView searchResultsView)
        {
            _searchResultsView = searchResultsView;
        }

        public async void GetMovies(string text)
        {
            string ApiUrl = Config.ApiUrl;
            HttpClient http = new HttpClient();

            try
            {
                _searchResultsView.Movies = await http.GetFromJsonAsync<List<MovieModel>>($"{ApiUrl}/search/{text}");

                PopulateSearchResultsDatagrid();
            }
            catch
            {
                MessageBox.Show("No movies found for this search query");
            }
        }

        public void GoToShowMovie(DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            var idColumnIndex = dataGrid.CurrentCell.ColumnIndex - 1;
            var movieId = dataGrid.Rows[e.RowIndex].Cells[idColumnIndex].Value;

            _searchResultsView.IndexView.ShowOnlyShowMovie(movieId.ToString());

        }

        private void PopulateSearchResultsDatagrid()
        {
            BindingSource movieSource = new BindingSource();
            movieSource.DataSource = _searchResultsView.Movies.Select(m => new { m.Id, m.Title, m.Overview });
            _searchResultsView.SearchResultsDataGrid.DataSource = movieSource;
            _searchResultsView.SearchResultsDataGrid.Columns[0].Visible = false;
        }
    }
}
