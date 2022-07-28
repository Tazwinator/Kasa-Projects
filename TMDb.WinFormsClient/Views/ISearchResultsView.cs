using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Forms;
using TMDb.WinFormsClient.Models;

namespace TMDb.WinFormsClient.Views
{
    public interface ISearchResultsView
    {
        public IIndexView IndexView { get; set; }
        public List<MovieModel> Movies { get; set; }
        void GetResults(string text);
        public SearchResults GetView();

        public DataGridView SearchResultsDataGrid { get; set; }
    }
}
