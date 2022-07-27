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

        public IMainPageView MainPageView { get; set; }
        public IShowMovieView ShowMovieView { get; set; }

        public ShowMovie ShowMovieControl { get; private set; }


        public IndexForm(IMainPageView mainPage, IShowMovieView showMovie)
        {
            InitializeComponent();

            this.MainPageView = mainPage;
            this.ShowMovieView = showMovie;

            

            _indexPresenter = new IndexPresenter(this);

        }

        #region Navigation

        private void NavBtn_Click(object sender, EventArgs e)
        {
            _indexPresenter.Navigation((Button)sender);

        }

        public void ShowOnlyMainPage()
        {
            _mainContentSplitContainer.Panel2.Controls.Remove(ShowMovieControl);
            _mainContentSplitContainer.Panel2.Controls.Add(_mainPage);
        }

        public void ShowOnlyShowMovie()
        {
            if (ShowMovieControl == null)
            {
                ShowMovieControl = ShowMovieView.GetView();
                ShowMovieControl.Dock = DockStyle.Fill;
            }

            _mainContentSplitContainer.Panel2.Controls.Remove(_mainPage);
            _mainContentSplitContainer.Panel2.Controls.Add(ShowMovieControl);
        }


        #endregion
    }
}
