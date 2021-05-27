using Lab_06_07_OOP.ViewModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab_06_07_OOP.Pages
{
    public partial class Delivery : Page
    {
        public Delivery()
        {
            InitializeComponent();
            DataContext = new ViewModelDelivery();
        }
    }
}