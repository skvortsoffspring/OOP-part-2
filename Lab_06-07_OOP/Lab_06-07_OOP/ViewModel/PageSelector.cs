using System.Windows;
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
        private Delivery _delivery;
        private Order _orderPage;
        private PageProducts _productsPage;
        private Comments _pageComments;
        private ViewModelCommands _selectPage;
        private Search _searchPage;
        
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
                                  case "order":
                                      PageFrameSelected = _orderPage;
                                      ShowFrame = Visibility.Visible;
                                      break;
                                  case "basket":
                                      PageFrameSelected = _basket;
                                      ShowFrame = Visibility.Visible;
                                      break;
                                  case "favorite":
                                      PageFrameSelected = _favorite;
                                      ShowFrame = Visibility.Visible;
                                      break;
                                  case "search":
                                      PageSelected = _searchPage;
                                      break;
                                  case "comments":
                                      PageFrameSelected = _pageComments;
                                      break;  
                                  case "delivery":
                                      _delivery = new Delivery();
                                      PageSelected = _delivery;
                                      break; 
                                  default:
                                      if(_homePage==null)
                                          _homePage = new PageHome();
                                      PageSelected = _homePage;
                                      break;
                              }
                          }));

    }
}