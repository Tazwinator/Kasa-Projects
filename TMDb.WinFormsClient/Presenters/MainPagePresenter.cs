using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.WinFormsClient.Views;

namespace TMDb.WinFormsClient.Presenters
{
    internal class MainPagePresenter
    {

        private IMainPageView _mainPage;

        public MainPagePresenter(IMainPageView mainPage)
        {
            _mainPage = mainPage;
        }
    }
}
