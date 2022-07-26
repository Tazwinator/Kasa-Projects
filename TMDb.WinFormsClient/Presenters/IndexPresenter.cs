using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        
    }
}
