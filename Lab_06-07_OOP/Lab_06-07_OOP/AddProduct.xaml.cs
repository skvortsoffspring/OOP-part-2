using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Image = System.Windows.Controls.Image;

namespace Lab_06_07_OOP
{
    public partial class AddProduct : Window
    {         
        private byte[] _thumbByteArray = null;
        private byte[] _imageFByteArray = null;
        private byte[] _imageSByteArray = null;
        private byte[] _imageTByteArray = null;
        private product _product = new product();
        public AddProduct()
        {
            InitializeComponent();
            Resources.MergedDictionaries.Add(MainWindow.Dictionary);
            InitCategories();
        }

        private void ButtonUploadImage_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog {Filter = @"Image files (*.jpg,*.png)|*.jpg;*.png"};
            var button = sender as Button;

            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(openFileDialog.FileName, UriKind.Absolute);
                bi.EndInit();
                var binArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                
                if ((binArray.Length / 1024) > 1024)
                {
                    ErrorMaxSize.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    Images.Visibility = Visibility.Visible;
                }
                
                switch (button.Name)
                {
                    case "imageThumb":
                        _thumbByteArray = binArray;
                        break;
                    case "imageFByteArray":
                        _imageFByteArray = binArray;
                        break;
                    case "imageSByteArray":
                        _imageSByteArray = binArray;
                        break;
                    case "imageTByteArray":
                        _imageTByteArray = binArray;
                        break;
                }

                var imageBrush = new ImageBrush();
                button.Background = new ImageBrush(bi);
            }
            else
            {
                ErrorMaxSize.Visibility = Visibility.Hidden;
                return;
            }
        }
        
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            //var image = new image();
            _product.ProductName = name.Text;
            _product.ProductShortDesc = shortDesc.Text;
            _product.ProductLongDesc = longDesc.Text;
            _product.ProductPrice = int.Parse(price.Text);
            _product.ProductStock = int.Parse(stock.Text);
            _product.ProductThumb = _thumbByteArray;
            _product.ProductImageF = _imageFByteArray;
            _product.ProductImageS = _imageSByteArray;
            _product.ProductImageT = _imageTByteArray;
            //product.ProductCategory = MainWindow.Market.productcategories.Where(p=>p.CategoryName == ProductCategory.Text).First().CategoryID;
            MainWindow.Market.products.Add(_product);
            MainWindow.Market.SaveChanges();
            
            var count = MainWindow.Market.products.Count();
        }

        private void InitCategories()
        {
            foreach (var productCategory in MainWindow.Market.productcategories)
            {
                ProductCategory.Items.Add(productCategory.CategoryName);
            }
        }
    }
}