using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.UI;
using Path = System.IO.Path;

namespace Lab_06_07_OOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            AddContent();
        }

        private void AddContent()
        {
            //WrapPanelContent.Children.Clear();
            // border style
            for (int i = 0; i < 40; i++)
            {
                
                // grid
                var grid = new Grid();
                var column = new ColumnDefinition {Width = new GridLength(230)};
                var row1 = new RowDefinition {Height = new GridLength(230)};
                var row2 = new RowDefinition {Height = new GridLength(40)};
                grid.ColumnDefinitions.Add(column);
                grid.RowDefinitions.Add(row1);
                grid.RowDefinitions.Add(row2);
                grid.Margin = new Thickness(10);

                // border 
                var border = new Border
                {
                    BorderBrush = Brushes.Gray,
                    Margin = new Thickness(10),
                    BorderThickness = new Thickness(2)
                };


                // image
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                var imgPath = Path.Combine(outPutDirectory, "..\\..\\img\\laptop\\Dell\\e6440\\preview.jpg");
                var img_path = new Uri(imgPath).LocalPath;
                var image = new Image
                {
                    Source = new BitmapImage(new Uri(img_path, UriKind.Absolute))
                };
                Grid.SetColumn(image,0);
                Grid.SetRow(image,0);
            
                // button
                var button = new Button {Content = "Latitude E6440", Height = 40, Width = 230};
                button.Click += Button_Info_Product_OnClick;
                button.Command = WindowCommands.Info;
                Grid.SetColumn(button,0);
                Grid.SetRow(button,1);

                // add ti child
                border.Child = grid;
                grid.Children.Add(image);
                grid.Children.Add(button);

            
                WrapPanelContent.Children.Add(border);

            }
        }

        private void Button_Info_Product_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                GridContent.Children.Clear();
                
                var grid = new Grid();
                grid.ShowGridLines = true;
                var column1 = new ColumnDefinition {Width = new GridLength(1,GridUnitType.Star)};
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

                // image
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                var imgPath = Path.Combine(outPutDirectory, "..\\..\\img\\laptop\\Dell\\e6440\\e6440-1.jpg");
                var img_path = new Uri(imgPath).LocalPath;
                var image = new Image
                {
                    Source = new BitmapImage(new Uri(img_path, UriKind.Absolute)),
                    Margin = new Thickness(50)
                };
                Grid.SetColumn(image,0);
                Grid.SetRow(image,0);


                var label = new Label()
                {
                    Content = "535$",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 48
                };
                
                Grid.SetColumn(label,1);
                Grid.SetRow(label,0);

                grid.Children.Add(label);
                grid.Children.Add(image);
                GridContent.Children.Add(grid);
            }
        }

        private void  Button_Add_Product_OnClick(object sender, RoutedEventArgs e)
        {
            var addProduct = new AddProduct();
            addProduct.Show();
        }
    }    
}
