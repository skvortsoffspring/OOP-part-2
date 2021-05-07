using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.Annotations;
using Lab_06_07_OOP.Pages;
using Lab_06_07_OOP.ServicesClasses;

namespace Lab_06_07_OOP.Models
{
    public class ModelProduct : product, INotifyPropertyChanged
    {
        private product _product = new();
        private BitmapImage _productThumbBitmapImage;
        private BitmapImage ProductImageBitmapImage;

        public int ProductID { get; set; }
        public Nullable<int> ProductCategory
        {
            get
            {
                return _product.ProductCategory;
            }
            set
            {
                _product.ProductCategory = value;
            }
        }
        public Nullable<int> ProductSubcategory
        {
            get
            {
                return _product.ProductSubcategory;
            }
            set
            {
                _product.ProductSubcategory = value;
            }
        }
        public Nullable<int> ProductCategoryMvvm
        {
            get
            {
                var productCategory = PageProducts.ViewModelProduct.ProductCategories.Where(productCategory => productCategory.CategoryID == _product.ProductCategory).First();
                return PageProducts.ViewModelProduct.ProductCategories.IndexOf(productCategory);
            }

            set
            {
                //_productCategory = PageProducts.ViewModelProduct.ProductCategories[(int)value].CategoryID;
                OnPropertyChanged("ProductCategory");
            }
        }
        public Nullable<int> ProductSubcategoryMvvm
        {
            get
            {
                var productSubcategory = PageProducts.ViewModelProduct.ProductSubcategories.Where(p => p.SubcategoryID == _product.ProductSubcategory).First();
                return PageProducts.ViewModelProduct.ProductSubcategories.IndexOf(productSubcategory);
            }

            set
            {
                //_productCategory = PageProducts.ViewModelProduct.ProductSubcategories[(int)value].SubcategoryID;
                OnPropertyChanged("ProductSubcategory");
            }
        }
        public string ProductName
        {
            get => _product.ProductName;
            set
            {
                _product.ProductName = value;
                OnPropertyChanged("ProductName");
            }
        }

        public string ProductDetails
        {
            get => _product.ProductDetails;
            set
            {
                _product.ProductDetails = value;
                OnPropertyChanged("ProductDetails");
            }
        }



        public BitmapImage ProductThumbBitmapImage
        {
            get { return ServicesConvert.ByteToBitmapImage(_product.ProductThumb); }
            set
            {
                _productThumbBitmapImage = ServicesConvert.ByteToBitmapImage(_product.ProductThumb);
            }
        }
        public BitmapImage ProductImageFBitmapImage
        {
            get { return ServicesConvert.ByteToBitmapImage(_product.ProductImage); }
            set { ProductImageBitmapImage = ServicesConvert.ByteToBitmapImage(_product.ProductImage); }
        }
        
        public byte[] ProductThumb
        {
            get => _product.ProductThumb;
            set
            {
                _product.ProductThumb = value;
                OnPropertyChanged("ProductThumbBitmapImage");
            }
        }

        public byte[] ProductImage
        {
            get => _product.ProductImage;
            set
            {
                _product.ProductImage = value;
                OnPropertyChanged("ProductImageFBitmapImage");
            }
        }
        public Nullable<int> ProductStock
        {
            get => _product.ProductStock;
            set
            {
                _product.ProductStock = value;
                OnPropertyChanged("ProductStock");
            }
        }
        public Nullable<double> ProductPrice
        {
            get => _product.ProductPrice;
            set
            {

                _product.ProductPrice = value;
                OnPropertyChanged("ProductPrice");

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}