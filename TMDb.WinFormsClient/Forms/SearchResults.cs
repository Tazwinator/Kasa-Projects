using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Presenters;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Forms
{
    public partial class SearchResults : UserControl, ISearchResultsView
    {


        private SearchResultsPresenter _searchResultsPresenter;

        public List<MovieModel> Movies { get; set; }
        public IIndexView IndexView { get; set; }
        public DataGridView SearchResultsDataGrid { get => _searchResultsDataGrid; set => _searchResultsDataGrid = value; }

        public SearchResults(IndexForm indexview)
        {

            InitializeComponent();

            IndexView = indexview;

            _searchResultsPresenter = new SearchResultsPresenter(this);

        }

        public void GetResults(string text)
        {
            _searchResultsPresenter.GetMovies(text);
        }

        private void MovieList_CellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            _searchResultsPresenter.GoToShowMovie((DataGridView)sender, e);
        }

        public SearchResults GetView()
        {
            return this;
        }
    }
}
