using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Forms;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Presenters
{
    internal class IndexPresenter
    {

        private IIndexView _indexView;

        public IndexPresenter(IIndexView indexView)
        {
            _indexView = indexView;
        }

        internal void BtnNavigation(Button sender)
        {
            switch (sender.Name)
            {
                case "_mainPageBtn":
                    // Already on the page
                    _indexView.ShowOnlyMainPage();
                    break;
                case "_showMovieBtn":
                    _indexView.ShowOnlyShowMovie(_indexView.ShowMovieView.MovieId);
                    break;
            }

        }

        internal void SearchForMovie(string text)
        {

            _indexView.ShowOnlySearchResults(text);
        }
    }
}
