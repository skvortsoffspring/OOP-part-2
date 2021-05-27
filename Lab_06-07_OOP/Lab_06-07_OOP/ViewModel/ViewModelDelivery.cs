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
    
    public class ViewModelDelivery : INotifyPropertyChanged
    {
        private ObservableCollection<order> _orders;
        private DateTime _date;
        private string _dateCulture = string.Empty;
        private ViewModelCommands _delProductCommand;
        private ObservableCollection<orderdetail> _orderDetails = new (MainWindow.Market.orderdetails);

        public ViewModelDelivery()
        {
            Date = DateTime.Now;
            foreach (var orderdetail in Orderdetails)
            {
                orderdetail.DetailsProduct = MainWindow.Market.products
                    .Where(p => p.ProductID == orderdetail.DetailsProductID).First();
            }
        }

        public DateTime Date
        { 
            get => _date;
            set
            {
                _date = value;
                DateCulture = _date.ToString("dddd dd MMMM",
                  CultureInfo.CreateSpecificCulture("ru-RU"));
                SortToDate();
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

       private void  SortToDate(){
           Orders = new ObservableCollection<order>(
               MainWindow.Market.orders.Local.Where(o => o.OrderDate == _date.Date));
                           


           foreach (var order in Orders)
           {
               order.OrderUser =
                   MainWindow.Market.users.SqlQuery(
                       "select * from Market.dbo.users where UserID = '" + order.OrderUserID +"' ").First();
           }
           
                           
        }
        public ViewModelCommands DeleteProduct
        {
            get
            {
                return _delProductCommand ??
                    (_delProductCommand = new ViewModelCommands(obj =>
                    {
                        orderdetail _orderdetail = obj as orderdetail;
                        if(_orderdetail != null)
                        {
                            order _order = _orderdetail.order;
                            _order.OrderAmount -= _orderdetail.product.ProductPrice;
                            MainWindow.Market.orderdetails.Remove(_orderdetail);
                            if (_order.orderdetails.Count == 0)
                                MainWindow.Market.orders.Remove(_order);
                            SortToDate();
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