using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Markup;
using Lab_06_07_OOP.Annotations;
using Lab_06_07_OOP.UI;
using Microsoft.Win32;

namespace Lab_06_07_OOP.mvvm
{
    public class ViewModel : INotifyPropertyChanged
    {
        private product _selectedProduct;
        private string _errorString = "";
        private ViewModelCommands _addProductCommand;
        private ViewModelCommands _delProductCommand;
        private ViewModelCommands _addImageCommand;
        private ObservableCollection<product> _products = MainWindow.Market.products.Local;

        public product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        public string ErrorString
        {
            get => _errorString;
            set
            {
                _errorString = value;
                OnPropertyChanged("ErrorString");
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

        public ObservableCollection<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.Local;
        
        public ViewModelCommands AddProductCommand
        {
            get
            {
                return _addProductCommand ??
                       (_addProductCommand = new ViewModelCommands(obj =>
                       {
                           var product = new product();
                           product.ProductCategory = MainWindow.Market.productcategories.First().CategoryID;
                           Products.Add(product);
                           MainWindow.Market.products.Add(product);
                           SelectedProduct = product;
                       }));
            }
        }
        
        public ViewModelCommands DelProductCommand
        {
            get
            {
                return _delProductCommand ??
                    (_delProductCommand = new ViewModelCommands(obj =>
                    {
                        MainWindow.Market.products.Remove(SelectedProduct);
                        Products.Remove(SelectedProduct);
                    }));
            }
        }
        public ViewModelCommands AddImageCommand
        {
            get
            {
                return _addImageCommand ??
                       (_addImageCommand = new ViewModelCommands(obj =>
                       {
                           byte[] binArray = OpenImageDialog();
                           if ((binArray.Length / 1024) > 1024)
                           {
                               ErrorString = "File more 1MB";
                               return;
                           }
                           else
                           {
                               ErrorString = "";
                           }
                           if(binArray == null) return;
                           switch (obj as string)
                           {
                               case "FirstImage":
                                   SelectedProduct.ProductImageF = binArray;
                                   break;
                               case "SecondImage":
                                   SelectedProduct.ProductImageS = binArray;
                                   break;
                               case "ThirdImage":
                                   SelectedProduct.ProductImageT = binArray;
                                   break;
                               default:
                                   SelectedProduct.ProductThumb = binArray;
                                   break;
                           }
                       }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private byte[] OpenImageDialog()
        {
            var openFileDialog = new OpenFileDialog {Filter = @"Image files (*.jpg,*.png)|*.jpg;*.png"};
            byte[] binArray = null;
            if (openFileDialog.ShowDialog() == true)
            {
                binArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
            }
            return binArray;
        }
    }
}

