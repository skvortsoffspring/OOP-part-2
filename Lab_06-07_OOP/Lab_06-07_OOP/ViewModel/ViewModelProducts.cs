using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
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
    public class ViewModelProduct : INotifyPropertyChanged
    {
        private product _selectedProduct = new();
        private productcategory _productCategory = new();
        private productsubcategory _productSubcategory = new();
        
        private string _errorString = "";
        private ViewModelCommands _addProductCommand;
        private ViewModelCommands _delProductCommand;
        private ViewModelCommands _addImageCommand;
        private ViewModelCommands _addCategoryCommand;
        private ViewModelCommands _delCategoryCommand;
        private ViewModelCommands _addSubcategoryCommand;
        private ViewModelCommands _delSubcategoryCommand;
                
        private ObservableCollection<product> _products = MainWindow.Market.products.Local;
        public  ObservableCollection<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.Local;
        private ObservableCollection<productsubcategory> _productSubcategories;


        public ObservableCollection<productsubcategory> ProductSubcategories
        {
            get => _productSubcategories;
            set
            {
                _productSubcategories = value; 
                OnPropertyChanged("ProductSubcategories");
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
        public productcategory ProductCategory
        {
            get => _productCategory;
            set
            {
                _productCategory = value;
                SelectedProduct.ProductCategory = _productCategory.CategoryID;
                SelectSubCategories();
                if(ProductSubcategories.Count!=0 && SelectedProduct.ProductSubcategory == null)
                    SelectedProduct.ProductSubcategory = ProductSubcategories.First().SubcategoryID;
                OnPropertyChanged("ProductCategory");
            }
        }  
        public productsubcategory ProductSubcategory
        {
            get => _productSubcategory;
            set
            {
                _productSubcategory = value;
                SelectedProduct.ProductSubcategory = ProductSubcategory.SubcategoryID;
                OnPropertyChanged("ProductSubcategory");
            }
        }

        private void SelectSubCategories()
        {
            ProductSubcategories = 
                new ObservableCollection<productsubcategory>(MainWindow.Market.productsubcategories.Local.Where(p => 
                    p.SubcategoryCategoryID == _productCategory.CategoryID));
        }

        public product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
       public ObservableCollection<product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged("ModelProduct");
            }
        }

        public ViewModelCommands AddProductCommand
        {
            get
            {
                return _addProductCommand ??
                       (_addProductCommand = new ViewModelCommands(obj =>
                       {
                           var product = new product();
                           product.ProductCategory = MainWindow.Market.productcategories.First().CategoryID;
                           product.ProductCategory = MainWindow.Market.productsubcategories.First().SubcategoryID;
                           Products.Add(product);
                           MainWindow.Market.products.Add(product);
                           MainWindow.Market.SaveChangesAsync();
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
                        MainWindow.Market.SaveChangesAsync();
                        Products.Remove(SelectedProduct);
                    }));
            }
        }
        public ViewModelCommands AddCategory
        {
            get
            {
                return _addCategoryCommand ??
                       (_addCategoryCommand = new ViewModelCommands(obj =>
                       {
                           MainWindow.Market.productcategories.Add(ProductCategory);  
                           ProductCategory = new productcategory();
                           MainWindow.Market.SaveChangesAsync();
                       }));
            }
        }
        public ViewModelCommands DelCategory
        {
            get
            {
                return _delCategoryCommand ??
                       (_delCategoryCommand = new ViewModelCommands(obj =>
                       {
                           if (_productCategory != null)
                           {
                               foreach (var productsubcategory in MainWindow.Market.productsubcategories)
                               {
                                   if (productsubcategory.SubcategoryCategoryID == _productCategory.CategoryID)
                                       MainWindow.Market.productsubcategories.Remove(productsubcategory);
                               }
                               MainWindow.Market.productcategories.Remove(_productCategory);
                               MainWindow.Market.SaveChangesAsync();
                           }
                       }));
            }
        }
        public ViewModelCommands AddSubcategory
        {
            get
            {
                return _addSubcategoryCommand ??
                       (_addSubcategoryCommand = new ViewModelCommands(obj =>
                       {
                           ProductSubcategory.SubcategoryCategoryID = SelectedProduct.ProductCategory.Value;
                           MainWindow.Market.productsubcategories.Add(ProductSubcategory);
                           ProductSubcategory = new productsubcategory();
                           MainWindow.Market.SaveChangesAsync();
                           SelectSubCategories();
                       }));
            }
        }
        public ViewModelCommands DelSubcategory
        {
            get
            {
                return _delSubcategoryCommand ??
                       (_delSubcategoryCommand = new ViewModelCommands(obj =>
                       {
                           if (_productSubcategory != null)
                           {
                               MainWindow.Market.productsubcategories.Remove(_productSubcategory);
                               MainWindow.Market.SaveChanges();
                               SelectSubCategories();
                           }
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
                               case "Image":
                                   SelectedProduct.ProductImage = binArray;
                                   break;
                               default:
                                   SelectedProduct.ProductThumb = binArray;
                                   break;
                           }
                           MainWindow.Market.SaveChangesAsync();
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

