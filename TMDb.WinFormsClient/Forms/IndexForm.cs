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

        public IndexForm()
        {
            InitializeComponent();

            _indexPresenter = new IndexPresenter(this);
        }

        #region Navigation


        private ShowMovie _showMovie;

        SplitContainer IIndexView.MainContentContainer 
        { 
            get => _mainContentSplitContainer; 
            set => _mainContentSplitContainer = value; 
        }

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
