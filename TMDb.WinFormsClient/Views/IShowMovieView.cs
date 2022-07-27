using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Forms;
using TMDb.WinFormsClient.Models;

namespace TMDb.WinFormsClient.Views
{
    public interface IShowMovieView
    {
        public IIndexView IndexView { get; set; }
        public string MovieId { get; set; }
        public MovieModel Movie {get; set;}
        ShowMovie GetView();
        void DisplayData();
        void LoadData();
    }
}
