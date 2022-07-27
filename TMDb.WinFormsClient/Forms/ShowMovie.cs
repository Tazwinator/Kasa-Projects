using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Forms
{
    public partial class ShowMovie : UserControl, IShowMovieView
    {
        public ShowMovie()
        {
            InitializeComponent();
        }

        public ShowMovie GetView()
        {
            return this;
        }
    }
}
