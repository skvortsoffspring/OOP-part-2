using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab_06_07_OOP
{
    public partial class MainWindow : Window
    {
        public static MarketEntities Market = new();
        public static ViewModel.ViewModel ViewModel ;
        public static byte? Role = 0;
        public static bool Entered = false;
        private ResourceDictionary resourceDict;
        public static ResourceDictionary Dictionary = new();
        public MainWindow()
        {
            InitializeComponent();
            Market.products.Load();
            Market.orders.Load();
            Market.productcategories.Load();
            Market.productsubcategories.Load();
            Market.comments.Load();
            DataContext = ViewModel = new ViewModel.ViewModel();

            Closed += (sender, args) =>
            {
                Market.SaveChanges();
            };

            List<string> styles = new List<string> { "Blue", "Red" };
            StyleBox.SelectionChanged += ThemeChange;
            StyleBox.ItemsSource = styles;
            StyleBox.SelectedItem = "Red";
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = StyleBox.SelectedItem as string;
            var uri = new Uri("Resources/" + style + ".xaml", UriKind.Relative);
            var uriOverride = new Uri("Resources/" + style + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
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
