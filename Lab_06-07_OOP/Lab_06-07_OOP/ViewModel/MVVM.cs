using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Lab_06_07_OOP.Annotations;

namespace Lab_06_07_OOP.ViewModel
{
    public class MVVM : INotifyPropertyChanged
    {
        public List<product> Products { get; set; } = MainWindow.Market.products.ToList();
        public List<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.ToList();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}