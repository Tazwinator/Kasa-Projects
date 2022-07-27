using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Presenters;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Forms
{
    public partial class MainPage : UserControl, IMainPageView
    {

        private MainPagePresenter _mainPagePresenter;

        public IIndexView IndexView { get; set; }

        public MainPage(IIndexView indexView)
        {
            InitializeComponent();

            IndexView = indexView;

            _mainPagePresenter = new MainPagePresenter(this);
            _mainPagePresenter.GetMoviesAsync();
        }

        DataGridView IMainPageView.HighestRatedMovies 
        { 
            get => _highestRatedDataGrid; 
            set => _highestRatedDataGrid = value; 
        }
        DataGridView IMainPageView.LatestReleasesMovies 
        { 
            get => _latestReleasesDataGrid; 
            set => _latestReleasesDataGrid = value; 
        }
        DataGridView IMainPageView.UpandComingMovies 
        { 
            get => _upAndComignDataGrid;
            set => _upAndComignDataGrid = value; 
        }

        public MainPage GetView()
        {
            return this;
        }

        private void MovieList_CellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            _mainPagePresenter.GoToShowMovie((DataGridView)sender, e);
        }
    }
}
