using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.Annotations;
using Lab_06_07_OOP.UI;

namespace Lab_06_07_OOP.ViewModel
{
    public class ListDeliviry
    {
        private string _productName;
        private string _productCategory;
        private string _productSubcategory;
        private double _productPrice;
    }
    public class ViewModelDelivery : INotifyPropertyChanged
    {
        private ObservableCollection<order> _orders;
        private DateTime _date = DateTime.Now;
        private string _dateCulture = string.Empty;
        private ViewModelCommands _foundOrders;
        private ObservableCollection<orderdetail> _orderDetails = new (MainWindow.Market.orderdetails);

        public DateTime Date
        { 
            get => _date;
            set
            {
                _date = value;
                DateCulture = _date.ToString("dddd dd MMMM",
                  CultureInfo.CreateSpecificCulture("ru-RU"));
                FoundOrders.Execute("");
                OnPropertyChanged("Date");
            }
        }
        public string DateCulture
        {
            get => _dateCulture;
            set
            {
                _dateCulture = value;
                OnPropertyChanged("DateCulture");
            }
        }
        public ObservableCollection<order> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public ObservableCollection<orderdetail> Orderdetails
        {
            get => _orderDetails;
            set
            {
                _orderDetails = value;
                OnPropertyChanged("Orderdetails");
            }
        }

        public ViewModelCommands FoundOrders
        {
            get
            {
                return _foundOrders ??
                       (_foundOrders = new ViewModelCommands(obj =>
                       {
                           Orders = new ObservableCollection<order>(
                               MainWindow.Market.orders.Where(o => o.OrderDate == _date.Date));
                           
                       foreach (var orderdetail in Orderdetails)
                           {
                               orderdetail.DetailsProduct = MainWindow.Market.products
                                   .Where(p => p.ProductID == orderdetail.DetailsProductID).First();
                           }

                       foreach (var order in Orders)
                       {
                           order.OrderUser =
                               MainWindow.Market.users.SqlQuery(
                                   "select * from Market.dbo.users where UserID = '" + order.OrderUserID +"' ").First();

                       }

                       }));
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