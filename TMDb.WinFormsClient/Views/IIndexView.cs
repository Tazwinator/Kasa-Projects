using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMDb.WinFormsClient.Views
{
    public interface IIndexView
    {

        public IMainPageView MainPageView { get; set; }
        public IShowMovieView ShowMovieView { get; set; }
        public ISearchResultsView SearchResultsView { get; set; }

        public void ShowOnlyMainPage();
        public void ShowOnlyShowMovie(string movieId);
        public void ShowOnlySearchResults(string text);

    }
}
