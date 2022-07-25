using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDb.WinFormsClient.Models;
using TMDb.WinFormsClient.Pages;

namespace TMDb.WinFormsClient
{
    public partial class Index : Form
    {

        // Movie Object Lists
        private List<MovieModel> _highestRated { get; set; }
        private List<MovieModel> _latestReleases { get; set; }
        private List<MovieModel> _upAndComing { get; set; }

        public Index()
        {
            InitializeComponent();

            //GetMoviesAsync();
        }

        private async void GetMoviesAsync()
        {
            var apiUrl = Program.Configuration["AppDataApiUri"];
            HttpClient http = new HttpClient();
            _highestRated = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/highestRatedLastYear");
            _latestReleases = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/latestReleases");
            _upAndComing = await http.GetFromJsonAsync<List<MovieModel>>($"{apiUrl}/home/upAndComing");

        }


        #region Navigation


        private ShowMovie _showMovie;

        private void FeaturedPageBtn_Click(object sender, EventArgs e)
        {
            // MainPage is always initialized so just needs bringing to the front.
            this._mainPage.BringToFront();
        }

        private void OtherPageTestBtn_Click(object sender, EventArgs e)
        {
            if (_showMovie == null)
            {
                _showMovie = new ShowMovie();
            }
            
            this._mainContentSplitContainer.Panel2.Controls.Add(_showMovie);
            _showMovie.Dock = DockStyle.Fill;
            _showMovie.BringToFront();
        }

        #endregion
    }
}
