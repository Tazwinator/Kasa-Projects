using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDb.WinFormsClient.Forms;
using TMDb.WinFormsClient.Models;

namespace TMDb.WinFormsClient.Views
{
    public interface IMainPageView
    {
        public DataGridView HighestRatedMovies { get; set; }
        public DataGridView LatestReleasesMovies { get; set; }
        public DataGridView UpandComingMovies { get; set; }

    }
}
