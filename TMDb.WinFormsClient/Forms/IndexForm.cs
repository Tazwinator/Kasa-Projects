using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDb.WinFormsClient.Presenters;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Forms
{
    public partial class IndexForm : Form, IIndexView
    {

        private IndexPresenter _indexPresenter;

        public IMainPageView MainPageView { get; set; }
        public IShowMovieView ShowMovieView { get; set; }
        public ISearchResultsView SearchResultsView { get; set; }

        public ShowMovie ShowMovieControl { get; private set; }
        public MainPage MainPageControl { get; private set; }
        public SearchResults SearchResultsControl { get; private set; }

        public IndexForm()
        {
            InitializeComponent();

            this.MainPageView = new MainPage(this);
            this.ShowMovieView = new ShowMovie(this);
            this.SearchResultsView = new SearchResults(this);

            MainPageControl = MainPageView.GetView();
            MainPageControl.Dock = DockStyle.Fill;
            _mainContentSplitContainer.Panel2.Controls.Add(MainPageControl);

            _indexPresenter = new IndexPresenter(this);

        }

        #region Navigation

        private void NavBtn_Click(object sender, EventArgs e)
        {
            _indexPresenter.BtnNavigation((Button)sender);

        }

        public void ShowOnlyMainPage()
        {
            _mainContentSplitContainer.Panel2.Controls.Remove(ShowMovieControl);
            _mainContentSplitContainer.Panel2.Controls.Add(MainPageControl);
        }

        public void ShowOnlyShowMovie(string movieId)
        {
            if (ShowMovieControl == null)
            {
                ShowMovieControl = ShowMovieView.GetView();
                ShowMovieControl.Dock = DockStyle.Fill;
            }

            _mainContentSplitContainer.Panel2.Controls.Clear();
            _mainContentSplitContainer.Panel2.Controls.Add(ShowMovieControl);
            ShowMovieView.MovieId = movieId;
            ShowMovieView.LoadData(); 
        }

        public void ShowOnlySearchResults(string text)
        {
            if (SearchResultsControl == null)
            {
                SearchResultsControl = SearchResultsView.GetView();
                SearchResultsControl.Dock = DockStyle.Fill;
            }

            _mainContentSplitContainer.Panel2.Controls.Clear();
            _mainContentSplitContainer.Panel2.Controls.Add(SearchResultsControl);
            SearchResultsView.GetResults(text);
        }



        #endregion

        private void _searchButton_Click(object sender, EventArgs e)
        {
            _indexPresenter.SearchForMovie(_movieSearchBox.Text);
        }

        private void _movieSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                _searchButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
