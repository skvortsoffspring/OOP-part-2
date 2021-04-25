using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using Lab_06_07_OOP.Annotations;
using Lab_06_07_OOP.UI;

namespace Lab_06_07_OOP.ViewModel
{
    public class Mvvm : INotifyPropertyChanged
    {
        private product _selectedProduct;
        private ViewModelCommands addCommand;
        private ObservableCollection<product> _products = new ObservableCollection<product>(MainWindow.Market.products);
        public product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        //public virtual ICollection<product> Products { get; set; } = MainWindow.Market.products;
        public ObservableCollection<product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged("Products");

            }
        }

        public List<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.ToList();
        


        public ViewModelCommands AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new ViewModelCommands(obj =>
                       {
                           var _product = new product();
                           _product.ProductCategory = 1;
                           MainWindow.Market.products.Add(_product);
                           Products.Add(_product);
                           SelectedProduct = _product;
                       }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}