using Lab_06_07_OOP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_06_07_OOP
{
    /// <summary>
    /// Логика взаимодействия для DeliveryWindow.xaml
    /// </summary>
    public partial class DeliveryWindow : Window
    {
        public DeliveryWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelDelivery();
            Closed += (sender, args) =>
            {
                Application.Current.MainWindow.Visibility = Visibility.Visible;
            };
        }
    }
}
