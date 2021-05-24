using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.Pages;
using Lab_06_07_OOP.ServicesClasses;
using Lab_06_07_OOP.UI;
using Microsoft.Win32;

namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel : INotifyPropertyChanged
    {
        
        private productcategory _productCategory;
        private product _selectedProduct = new();
        private productsubcategory _productSubcategory = new();
        private Visibility _showFrame = Visibility.Hidden;
        
        private string _errorString = "";
        private ViewModelCommands _addProductCommand;
        private ViewModelCommands _delProductCommand;
        private ViewModelCommands _addImageCommand;
        private ViewModelCommands _addCategoryCommand;
        private ViewModelCommands _delCategoryCommand;
        private ViewModelCommands _addSubcategoryCommand;
        private ViewModelCommands _delSubcategoryCommand;
        private ViewModelCommands _goCategoryCommand;
        private ViewModelCommands _incDecQuantity;
        private ViewModelCommands _hiddenProduct;
        private ViewModelCommands _showHiddenedProduct;


        private ObservableCollection<product> _products = MainWindow.Market.products.Local;
        public  ObservableCollection<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.Local;
        private ObservableCollection<productsubcategory> _productSubcategories;
        private productcategory _selectedCategory= new();
        private productsubcategory _selectedSubcategory = new();
        private ViewModelCommands _goSubcategoryCommand;

        public ViewModel()
        {
            PageSelected = _productsPage = new PageProducts();
            _productsPage.DataContext = this;
            _basket = new();
            _basket.DataContext = this;
            _favorite = new();
            _favorite.DataContext = this;
            _pageComments = new();         
            _pageComments.DataContext = this;
            _searchPage = new();
            _searchPage.DataContext = this;
            _orderPage = new();
            _orderPage.DataContext = this;


            if (MainWindow.Market.productcategories.Count() != 0)
            {
                ProductCategory = MainWindow.Market.productcategories.First();
                SelectedCategory = MainWindow.Market.productcategories.First();
            }
        }
        
        public Visibility ShowFrame
        {
            get => _showFrame;
            set
            {
                _showFrame = value;
                OnPropertyChanged("ShowFrame");
            }
        }

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
                if(_productCategory!=null)
                    SelectedProduct.ProductCategory = _productCategory.CategoryID;
                SelectSubCategories(_productCategory);
                if(SelectedProduct!=null)
                if (ProductSubcategories.Count != 0 && SelectedProduct.ProductSubcategory == null)
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
                if(ProductSubcategory!=null)
                SelectedProduct.ProductSubcategory = ProductSubcategory.SubcategoryID;
                OnPropertyChanged("ProductSubcategory");
            }
        }
        private void SelectSubCategories(productcategory category)
        {
            if(category!=null)
            ProductSubcategories =
                new ObservableCollection<productsubcategory>(MainWindow.Market.productsubcategories.Local.Where(p =>
                    p.SubcategoryCategoryID == category.CategoryID));
        }
        public product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                if (value != null)
                {
                    _selectedProduct = value;
                    OnPropertyChanged("SelectedProduct");
                    OnPropertyChanged("ProductCategoryBitmapImage");
                }
            }
        }
        public productcategory SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                _selectedCategory = value;
                SelectSubCategories(_selectedCategory);
                GoCategory.Execute(_selectedCategory.CategoryName);
                OnPropertyChanged("SelectedCategory");
            }
        }
        public productsubcategory SelectedSubcategory
        {
            get => _selectedSubcategory;
            set
            {
                _selectedSubcategory = value;
                GoSubcategory.Execute(_selectedCategory.CategoryName);
                OnPropertyChanged("SelectedSubcategory");
            }
        }
        public ObservableCollection<product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged("Products");
            }
        }
        public BitmapImage ProductCategoryBitmapImage
        {
            get
            {
                return ProductCategory!=null ? ServicesConvert.ByteToBitmapImage(ProductCategory.CategoryImage) : null;
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
                            //if (MainWindow.Market.productcategories.Count() != 0)
                            //    product.ProductCategory = MainWindow.Market.productcategories.First().CategoryID;
                            //if (MainWindow.Market.productsubcategories.Count() != 0)
                            //    product.ProductCategory = MainWindow.Market.productsubcategories.First().SubcategoryID;
                            Products.Add(product);
                            MainWindow.Market.products.Add(product);
                            MainWindow.Market.SaveChanges();
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
                        foreach (var orderdetail in MainWindow.Market.orderdetails)
                        {
                            if (orderdetail.DetailsProductID != null && orderdetail.DetailsProductID.Value == SelectedProduct.ProductID)
                                orderdetail.DetailsProductID = null;
                        }

                        foreach (var comment in MainWindow.Market.comments)
                        {
                            if (SelectedProduct.ProductID == comment.CommentProductID)
                                MainWindow.Market.comments.Remove(comment);
                        }
                        MainWindow.Market.products.Remove(SelectedProduct);
                        MainWindow.Market.SaveChanges();
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
                           if (ProductCategory != null)
                           {
                               ProductCategory = new productcategory();
                               ProductCategory.CategoryName = "Новая";
                               MainWindow.Market.productcategories.Add(ProductCategory);
                               MainWindow.Market.SaveChangesAsync();
                           }
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
                           if (SelectedProduct.ProductCategory != null)
                           {
                               ProductSubcategory.SubcategoryCategoryID = SelectedProduct.ProductCategory.Value;
                               ProductSubcategory.SubcategoryName = "Новая";
                               MainWindow.Market.productsubcategories.Add(ProductSubcategory);
                               ProductSubcategory = new productsubcategory();
                               MainWindow.Market.SaveChangesAsync();
                               SelectSubCategories(_productCategory);
                           }
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
                               foreach (var product in MainWindow.Market.products)
                               {
                                   if(product.ProductSubcategory != null)
                                   if (product.ProductSubcategory.Value == _productSubcategory.SubcategoryID)
                                       product.ProductSubcategory  = null;
                               }
                               MainWindow.Market.productsubcategories.Remove(_productSubcategory);
                               MainWindow.Market.SaveChanges();
                               SelectSubCategories(_productCategory);
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
                           if (binArray == null) return;
                           if ((binArray.Length / 1024) > 1024)
                           {
                               ErrorString = "Файл больше мегабайта";
                               return;
                           }
                           else
                           {
                               ErrorString = "";
                           }

                           switch (obj as string)
                           {
                               case "Image":
                                   SelectedProduct.ProductImage = binArray;
                                   break;
                               case "Category":
                                   ProductCategory.CategoryImage = binArray;
                                   break;
                               default:
                                   SelectedProduct.ProductThumb = binArray;
                                   break;
                           }
                           MainWindow.Market.SaveChangesAsync();
                       }));
            }
        }
        public ViewModelCommands GoCategory
        {
            get
            {
                return _goCategoryCommand ??
                       (_goCategoryCommand = new ViewModelCommands(obj =>
                       {
                           PageSelected = _productsPage;
                           string category = obj as string;
                           Products = new ObservableCollection<product>(MainWindow.Market.products.Local.Where(product =>
                               product.ProductCategory == SelectedCategory.CategoryID));
                       }));
            }
        }
        public ViewModelCommands IncDecQuantity
        {
            get
            {
                return _incDecQuantity ??
                       (_incDecQuantity = new ViewModelCommands(obj =>
                       {
                           string operation = obj as string;
                           switch (operation)
                           {
                               case "dec":
                                   if (SelectedProduct.QuantityInTheOrder > 1)
                                       SelectedProduct.QuantityInTheOrder--;
                                   break;
                               case "inc":
                                   if (SelectedProduct.QuantityInTheOrder < Int32.MaxValue)
                                       SelectedProduct.QuantityInTheOrder++;
                                   break;
                           }
                           
                       }));
            }
        }
        public ViewModelCommands GoSubcategory
        {
            get
            {
                return _goSubcategoryCommand ??
                       (_goSubcategoryCommand = new ViewModelCommands(obj =>
                       {
                           string category = obj as string;
                           if(SelectedSubcategory!=null)
                           Products = new ObservableCollection<product>(MainWindow.Market.products.Local.Where(product =>
                               product.ProductSubcategory == SelectedSubcategory.SubcategoryID));
                       }));
            }
        }
        public ViewModelCommands HiddenProduct
        {
            get
            {
                return _hiddenProduct ??
                       (_hiddenProduct = new ViewModelCommands(obj =>
                       {
                           if (SelectedProduct != null)
                           {
                               SelectedProduct.ProductSubcategory = null;
                               SelectedProduct.ProductCategory = null;
                           }
                       }));
            }
        }        
        public ViewModelCommands ShowHiddenedProduct
        {
            get
            {
                return _showHiddenedProduct ??
                       (_showHiddenedProduct = new ViewModelCommands(obj =>
                       {
                           Products = new ObservableCollection<product>(MainWindow.Market.products.Local.Where(p => p.ProductCategory == null));
                       }));
            }
        }
        private byte[] OpenImageDialog()
        {
            var openFileDialog = new OpenFileDialog { Filter = @"Image files (*.jpg,*.png)|*.jpg;*.png" };
            byte[] binArray = null;
            if (openFileDialog.ShowDialog() == true)
            {
                binArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
            }
            else
            {
                return null;
            }
            return binArray;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

