using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.Annotations;

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
        private ObservableCollection<order> _orders = new ObservableCollection<order>(MainWindow.Market.orders);
        private DateTime _date;
        private string st = "asdasd";
        public string ST 
        { 
            get => st;
            set
            {
                st = value;
                OnPropertyChanged("ST");
            }
        }

        public DateTime Date
        { 
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged("Date");
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}