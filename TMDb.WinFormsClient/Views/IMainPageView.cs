using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDb.WinFormsClient.Models;

namespace TMDb.WinFormsClient.Views
{
    internal interface IMainPageView
    {
        internal DataGridView HighestRatedMovies { get; set; }
        internal DataGridView LatestReleasesMovies { get; set; }
        internal DataGridView UpandComingMovies { get; set; }

    }
}
