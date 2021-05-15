using Lab_06_07_OOP.Pages;
using Lab_06_07_OOP.UI;
using System.Windows.Controls;


namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel
    {
        private Page _page;             
        private Page _pageFrame; 
        private Favorite _favorite;
        private PageHome _homePage;
        private PageProducts _productsPage;
        private Comments _pageComments;
        private ViewModelCommands _selectPage;
        
        public Page PageSelected
        {
            get => _page;
            set
            {
                _page = value;
                OnPropertyChanged("PageSelected");
            }
        }
        public Page PageFrameSelected 
        {
            get => _pageFrame;
            set
            {
                _pageFrame = value;
                OnPropertyChanged("PageFrameSelected");
            }
        }

        public ViewModelCommands 
            SelectPage => _selectPage ??
                          (_selectPage = new ViewModelCommands(obj =>
                          {
                              switch (obj as string)
                              {
                                  case "basket":
                                      PageSelected = _basket;
                                      break;
                                  case "favorite":
                                      PageSelected = _favorite;
                                      break;
                                  case "comments":
                                      PageFrameSelected = _pageComments;
                                      break;
                                  default:
                                      if(_homePage==null)
                                          _homePage = new();
                                      PageSelected = _homePage;
                                      break;
                              }
                          }));

    }
}