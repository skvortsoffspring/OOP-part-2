using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using Lab_06_07_OOP.Annotations;
using Lab_06_07_OOP.Pages;
using Lab_06_07_OOP.UI;
using Microsoft.Win32;

namespace Lab_06_07_OOP.mvvm
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _login = "";
        private string _password = ""; 
        private string _passwordRepeat = "";

        public string PasswordRepeat
        {
            get => _passwordRepeat;
            set => _passwordRepeat = value;
        }

        private Page _page;
        private productcategory _productCategory;
        
        private PageHome _homePage = new();
        private PageProducts _productsPage = new ();
        private PageWarranty _warrantyPage = new();
        
        private ViewModelCommands _selectPage;
        private ViewModelCommands _selectCategoryCommand;
        private double _frameOpacity;

        public ViewModel()
        {
            PageSelected = _productsPage;
            ProductCategory = MainWindow.Market.productcategories.First();
        }

        public ObservableCollection<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.Local;
        private ObservableCollection<productsubcategory> _productSubcategories;
        private ViewModelCommands _goLogging;

        public ObservableCollection<productsubcategory> ProductSubcategories
        {
            get => _productSubcategories;
            set
            {
                _productSubcategories = value; 
                OnPropertyChanged("ProductSubcategories");
            }
        }
        public productcategory ProductCategory
        {
            get => _productCategory;
            set
            {
                _productCategory = value;
                OnPropertyChanged("ProductCategory");
            }
        }  
        public double FramaOpacity
        {
            get => _frameOpacity;
            set
            {
                _frameOpacity = value;
                OnPropertyChanged("FramaOpacity");
            } 
        }
        public string Login
        {
            get => _login;
            set => _login = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public Page PageSelected
        {
            get => _page;
            set
            {
                _page = value; 
                OnPropertyChanged("PageSelected");
            }
        }
        public ViewModelCommands SelectPage
        {
            get
            {
                return _selectPage ??
                       (_selectPage = new ViewModelCommands(obj =>
                       {
                           switch (obj as string)
                           {
                               case "products":
                                   AnimateOpacity(_productsPage);
                                   break;
                               case "warranty":
                                   AnimateOpacity(_warrantyPage);
                                   break;
                               default:
                                   AnimateOpacity(_homePage);
                                   break;
                                   
                           }
                       }));
            }
        }
        public ViewModelCommands GoLogging
        {
            get
            {
                return _goLogging ??
                       (_goLogging = new ViewModelCommands(obj =>
                       {
                           
                       }));
            }
        }

       
        private async void AnimateOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
                {
                    for (double i = 1.0; i < 0.0; i -= 0.1)
                    {
                        FramaOpacity = i;
                        Thread.Sleep(50);
                    }

                    PageSelected = page;
                    for (double i = 0.0; i < 1.0; i += 0.1)
                    {
                        FramaOpacity = i;
                        Thread.Sleep(50);
                    }
                }

            );
        }
        public ViewModelCommands AddCategory
        {
            get
            {
                return _selectCategoryCommand ??
                       (_selectCategoryCommand = new ViewModelCommands(obj =>
                       {
                           ProductCategory = new productcategory();
                           MainWindow.Market.productcategories.Add(ProductCategory);
                       }));
            }
        }
        private void SelectSubCategories()
        {
            ProductSubcategories = 
                new ObservableCollection<productsubcategory>(MainWindow.Market.productsubcategories.Local.Where(p => 
                    p.SubcategoryCategoryID == _productCategory.CategoryID));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

