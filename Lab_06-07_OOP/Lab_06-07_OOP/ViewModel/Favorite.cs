using System.Collections.ObjectModel;
using Lab_06_07_OOP.UI;

    namespace Lab_06_07_OOP.ViewModel
    {
        public partial class ViewModel
        {
            private ObservableCollection<product> _shoppingFavorite = new();
            private int _countProductFavorite;
            private ViewModelCommands _actionsFavorite;
        
        public ObservableCollection<product> ShoppingFavorite
        {
            get => _shoppingFavorite ;
            set
            {
                _shoppingFavorite  = value;
                OnPropertyChanged("ShoppingFavorite");
            }
        }
        public int CountProductFavorite
        {
            get => _countProductFavorite;
            set
            {
                _countProductFavorite = value;
                OnPropertyChanged("CountProductFavorite");
            }
        }
        public void AddProductFavorite()
        {
            if (SelectedProduct != null)
            {
                if(ShoppingFavorite.IndexOf(SelectedProduct)==-1)
                    ShoppingFavorite.Add(SelectedProduct);
            }
            CountProductFavorite = ShoppingFavorite.Count;
        }

        public void DelPProductFavorite()
        {
            if (SelectedProduct != null)
                ShoppingBasket.Remove(SelectedProduct);
            CountProductFavorite = ShoppingFavorite.Count;
        }
        
        public ViewModelCommands ActionsFavorite
        {
            get
            {
                return _actionsFavorite ??
                       (_actionsFavorite= new ViewModelCommands(obj =>
                       {
                           switch (obj as string)
                           {
                               case "add":
                                   AddProductFavorite();
                                   break;
                               case "del":
                                   DelPProductFavorite();
                                   break;
                           }
                       }));
            }
        }
    }
}
