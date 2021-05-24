using System;
using System.Collections.ObjectModel;
using System.Windows;
using Lab_06_07_OOP.Pages;
using Lab_06_07_OOP.UI;

namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel
    {
        private ObservableCollection<product> _shoppingBasket = new();
        private Basket _basket;
        private int _countProductBasket;
        private double _purchasePrice;
        private ViewModelCommands _actionsBasket;

        public ObservableCollection<product> ShoppingBasket
        {
            get => _shoppingBasket;
            set
            {
                _shoppingBasket = value;
                OnPropertyChanged("ShoppingBasket");
            }
        }
        public Basket Basket
        {
            get => _basket;
        }
        public double PurchasePrice
        {
            get=>_purchasePrice;
            set
            {
                _purchasePrice = value;
                OnPropertyChanged("PurchasePrice");
            }
        }
        public int CountProductBasket
        {
            get => _countProductBasket;
            set
            {
                _countProductBasket = value;
                OnPropertyChanged("CountProductBasket");
            }
        }
        private void AddProductBasket()
        {
            if (SelectedProduct != null)
                for (int i = 0; i < SelectedProduct.QuantityInTheOrder; i++)
                {
                     ShoppingBasket.Add(SelectedProduct);
                     CountProductBasket++;
                     if (SelectedProduct.ProductPrice != null) _purchasePrice += SelectedProduct.ProductPrice.Value;
                     PurchasePrice = Math.Round(_purchasePrice,2);
                }
            CountProductBasket = ShoppingBasket.Count;
        }
        private void DelPProductBasket()
        {
            if (SelectedProduct != null)
                    ShoppingBasket.Remove(SelectedProduct);
            if (SelectedProduct != null) _purchasePrice -= SelectedProduct.ProductPrice.Value;
            PurchasePrice = Math.Round(PurchasePrice,2);
            CountProductBasket--;
               
        }
        public ViewModelCommands ActionsBasket
        {
            get
            {
                return _actionsBasket ??
                       (_actionsBasket = new ViewModelCommands(obj =>
                       {
                           switch (obj as string)
                           {
                               case "add":
                                   AddProductBasket();
                                   break;
                               case "del":
                                   DelPProductBasket();
                                   break;
                           }
                       }));
            }
        }
       
    }
}