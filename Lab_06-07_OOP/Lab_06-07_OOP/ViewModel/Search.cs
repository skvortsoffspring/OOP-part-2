using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel
    {
        private string _fieldSearch;
        private ObservableCollection<product> _productsFounded = new (MainWindow.Market.products.Local.Where(p=>p.ProductCategory != null));
        private int _foundedSize;

        public int FoundedSize
        {
            get => _foundedSize;
            set
            {
                _foundedSize = value;
                OnPropertyChanged("FoundedSize");
            }
        }

        public ObservableCollection<product> ProductsFounded
        {
            get => _productsFounded;
            set
            {
                _productsFounded = value; 
                OnPropertyChanged("ProductsFounded");
            }
        }

        public string FieldSearch
        {
            get => _fieldSearch;
            set
            {
                _fieldSearch = value;
                if (PageSelected != _searchPage)
                    _selectPage.Execute("search");
                SearchAsync();
            }
        }

        private async void SearchAsync()
        {
            await Task.Run(() => Search());
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(_fieldSearch))
            {
                ProductsFounded = new ObservableCollection<product>(MainWindow.Market.products.Local.Where(p=>p.ProductCategory != null));
                FoundedSize = ProductsFounded.Count();
                return;
            }
            ProductsFounded =
                new ObservableCollection<product>(MainWindow.Market.products.Local.Where(p => (p.ProductName.ToLower().Contains(FieldSearch.ToLower())) && p.ProductCategory != null));
            FoundedSize = ProductsFounded.Count();
        }
        private void ShowHidden()
        {
            ProductsFounded = new ObservableCollection<product>(MainWindow.Market.products.Local.Where(p => p.ProductCategory == null));
        }
    }
}