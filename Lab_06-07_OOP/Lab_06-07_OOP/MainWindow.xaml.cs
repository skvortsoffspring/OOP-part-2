using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.UI;
using Lab_06_07_OOP.ViewModel;
using Brushes = System.Windows.Media.Brushes;
using Image = System.Windows.Controls.Image;
using Path = System.IO.Path;

namespace Lab_06_07_OOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Entities Market = new Entities();
        private bool _test = true;
        public static ResourceDictionary Dictionary = new ResourceDictionary();
        public MainWindow()
        {
            InitializeComponent();
            Mvvm mvvm = new Mvvm();
            DataContext = mvvm;
            SetLanguageDictionary(null,null);

            Closed += (sender, args) =>
            {
                Market.SaveChanges();
            };
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        private void SetLanguageDictionary(object sender, RoutedEventArgs routedEventArgs)
        {
            var lang = "ru-RU";
        
                    
            // switch (lang)//(Thread.CurrentThread.CurrentCulture.ToString())
            // {
            //     case "en-US":
            //         dict.Source = new Uri("..\\Resources\\Resources.en-US.xaml", UriKind.Relative);
            //         break;
            //     case "ru-RU":
            //         dict.Source = new Uri("..\\Resources\\Resources.ru-RU.xaml", UriKind.Relative);
            //         break;
            // }
            // this.Resources.MergedDictionaries.Add(dict);
            switch (_test)//(Thread.CurrentThread.CurrentCulture.ToString())
            {
                case true:
                    Dictionary.Source = new Uri("..\\Resources\\Resources.en-US.xaml", UriKind.Relative);
                    _test = false;
                    break;
                case false:
                    Dictionary.Source = new Uri("..\\Resources\\Resources.ru-RU.xaml", UriKind.Relative);
                    _test = true;
                    break;
                default :
                    Dictionary.Source = new Uri("..\\Resources\\Resources.en-US.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Add(Dictionary);
                    
            //QuantityProduct.Content = "Products: " + Market.products.Count();
        }

    }    
}
