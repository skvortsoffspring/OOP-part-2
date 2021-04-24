using System;
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
        private bool test = true;
        public static ResourceDictionary Dictionary = new ResourceDictionary();
        public MainWindow()
        {
            this.SetLanguageDictionary(null,null);
            InitializeComponent();
            DataContext = new MVVM();
            //AddContent(null,null);
        }

        private void AddContent(object sender, RoutedEventArgs e)
        {
            // INTERFACE //
            var iconDelete = new Image()
            {
                Source = new BitmapImage(new Uri(@"D:\University\Labs\OOP part 2\Lab_06-07_OOP\Lab_06-07_OOP\img\interface\delete.png", UriKind.Absolute))
            };

            //GridContent.Children.Clear();
        
            var wrapPanel = new WrapPanel();
            wrapPanel.HorizontalAlignment = HorizontalAlignment.Center;
            wrapPanel.Name = "WrapPanelContent";

            foreach (var product in Market.products)
            {
                // grid
                var grid = new Grid();
                var column = new ColumnDefinition {Width = new GridLength(200)};
                var row1 = new RowDefinition {Height = new GridLength(200)};
                var row2 = new RowDefinition {Height = new GridLength(40)};
                var row3 = new RowDefinition {Height = new GridLength(40)};
                grid.ColumnDefinitions.Add(column);
                grid.RowDefinitions.Add(row1);
                grid.RowDefinitions.Add(row2);
                grid.RowDefinitions.Add(row3);
                grid.Margin = new Thickness(10);
                
                var border = new Border
                {
                    BorderBrush = Brushes.Gray,
                    Margin = new Thickness(10),
                    BorderThickness = new Thickness(2)
                };

                var imageBytes = product.ProductThumb;
                var image = new Image();
                image.Source = LoadImage(imageBytes);
                
                Grid.SetColumn(image,0);
                Grid.SetRow(image,0);
                
                var button = new Button {Content = product.ProductName, Height = 40, Width = 200};
                button.Click += Button_Info_Product_OnClick;
                button.Command = WindowCommands.Info;
                var idProduct = "ID"+Convert.ToString(product.ProductID);
                button.Name = idProduct;
                var label = new Label();
                label.Content = product.ProductPrice + "$";
                
                Grid.SetColumn(button,0);
                Grid.SetRow(button,1);               
                Grid.SetColumn(label,0);
                Grid.SetRow(label,0);
                Grid.SetColumn(iconDelete,0);
                Grid.SetRow(iconDelete,2);
                
                border.Child = grid;
                grid.Children.Add(image);
                grid.Children.Add(label);
                //grid.Children.Add(iconDelete);
                grid.Children.Add(button);

            
                wrapPanel.Children.Add(border);
            }

            //GridContent.Children.Add(wrapPanel);
        }

        private void Button_Info_Product_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                //GridContent.Children.Clear();
                var name = button.Name;
                var grid = new Grid();
                grid.ShowGridLines = true;
                var column1 = new ColumnDefinition {Width = new GridLength(2,GridUnitType.Star)};
                var column2 = new ColumnDefinition {Width = new GridLength(1,GridUnitType.Star)};
                column1.MaxWidth = 450;
                
                var row1 = new RowDefinition {Height = new GridLength(1, GridUnitType.Star)};
                var row2 = new RowDefinition {Height = new GridLength(40)};
                var row3 = new RowDefinition {Height = new GridLength(40)};
                var row4 = new RowDefinition {Height = new GridLength(40)};
                var row5 = new RowDefinition {Height = new GridLength(40)};
                
                grid.ColumnDefinitions.Add(column1);
                grid.RowDefinitions.Add(row1);
                grid.ColumnDefinitions.Add(column2);
                grid.RowDefinitions.Add(row2);
                grid.RowDefinitions.Add(row3);
                grid.RowDefinitions.Add(row4);
                grid.RowDefinitions.Add(row5);
                
                var id = (button.Name.ToString()).Substring(2); 
                var result = Market.products.Find(int.Parse(id));
                
                var image = new Image
                {
                    Source = LoadImage(result.ProductThumb),
                    Margin = new Thickness(50)
                };
                
                Grid.SetColumn(image,0);
                Grid.SetRow(image,0);


                var label = new Label()
                {
                    Content = result.ProductStock,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 48
                };
                
                Grid.SetColumn(label,1);
                Grid.SetRow(label,0);

                grid.Children.Add(label);
                grid.Children.Add(image);
               // GridContent.Children.Add(grid);
            }
        }

        private void  Button_Add_Product_OnClick(object sender, RoutedEventArgs e)
        {
            var addProduct = new AddProduct();
            addProduct.Show();
        }

        private void Button_Del_Product_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                var ID = int.Parse(button.Name.ToString().Substring(2));
                var prod = Market.products.Where(p=> p.ProductID == ID).First();
                Market.products.Remove(prod);
            }
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
                    switch (test)//(Thread.CurrentThread.CurrentCulture.ToString())
                    {
                        case true:
                            Dictionary.Source = new Uri("..\\Resources\\Resources.en-US.xaml", UriKind.Relative);
                            test = false;
                            break;
                        case false:
                            Dictionary.Source = new Uri("..\\Resources\\Resources.ru-RU.xaml", UriKind.Relative);
                            test = true;
                            break;
                        default :
                            Dictionary.Source = new Uri("..\\Resources\\Resources.en-US.xaml", UriKind.Relative);
                            break;
                    }
                    Resources.MergedDictionaries.Add(Dictionary);
                }

    }    
}
