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
    public partial class ShowMovie : UserControl, IShowMovieView
    {
        public IIndexView IndexView { get; set; }

        private ShowMoviePresenter _showMoviePresenter;
        public string MovieId { get; set; } = "0";
        public MovieModel Movie { get; set; }

        public ShowMovie(IIndexView indexView)
        {
            InitializeComponent();

            IndexView = indexView;

            _showMoviePresenter = new ShowMoviePresenter(this);
            
        }


        public ShowMovie GetView()
        {
            return this;
        }

        public void DisplayData()
        {
            _posterImageBox.LoadAsync($"https://www.themoviedb.org/t/p/w300{Movie.PosterPath}");
            _runtimeLabel.Text = Movie.Runtime;
            _releaseDateLabel.Text = $"{Movie.ReleaseDate.Day}/{Movie.ReleaseDate.Month}/{Movie.ReleaseDate.Year}";
            _titleLabel.Text = Movie.Title;
            _synopsisTextBox.Text = Movie.Overview;
        }

        public void LoadData()
        {
            _showMoviePresenter.GetMovieAsync(MovieId);
        }
    }
}
