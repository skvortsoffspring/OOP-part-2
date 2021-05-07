using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using Lab_06_07_OOP.UI;
using Lab_06_07_OOP.mvvm;
using Lab_06_07_OOP.Pages;
using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
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
        public static Entities Market = new();
        public static ViewModel ViewModel = new();
        private bool _test = true;
        private ResourceDictionary resourceDict;
        public static ResourceDictionary Dictionary = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<Entities>());
            Market.products.Load();
            Market.productcategories.Load();
            Market.productsubcategories.Load();
            SetLanguageDictionary(null,null);

            Closed += (sender, args) =>
            {
                Market.SaveChanges();
            };

            List<string> styles = new List<string> { "Blue", "Dark" };
            StyleBox.SelectionChanged += ThemeChange;
            StyleBox.ItemsSource = styles;
            StyleBox.SelectedItem = "Blue";
        }
 
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = StyleBox.SelectedItem as string;
            var uri = new Uri("Resources/" +style + ".xaml", UriKind.Relative);
            if (resourceDict != null) Application.Current.Resources.Remove(resourceDict);
            resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
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


        private void ShowFormLogin(object sender, RoutedEventArgs e)
        {
            Logging.Visibility = Visibility.Visible;
        }

        private void HideLoggingForm(object sender, ExecutedRoutedEventArgs e)
        {
            Logging.Visibility = Visibility.Hidden;
        }
    }    
}
