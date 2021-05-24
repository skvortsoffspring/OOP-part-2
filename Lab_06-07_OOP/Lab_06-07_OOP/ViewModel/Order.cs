using System;
using System.Windows;
using Lab_06_07_OOP.UI;

namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel
    {
        private ViewModelCommands _arrangeBasket;
        private order _order;
        private string _orderCountry = "Беларусь";

        public order Order
        {
            get => _order;
            set => _order = value;
        }

        public string OrderCountry
        {
            get => _orderCountry;
            set => _orderCountry = value;
        }

        public string OrderCity
        {
            get => _orderCity;
            set => _orderCity = value;
        }  

        public string OrderAddress
        {
            get => _orderAddress;
            set => _orderAddress = value;
        }

        private string _orderCity = "";
        private string _orderAddress = "";

        public ViewModelCommands ArrangeBasket
                {
                    get
                    {
                        return _arrangeBasket ??
                               (_arrangeBasket = new ViewModelCommands(obj =>
                               {
                                    if (!MainWindow.Entered)
                                   {
                                        MessageBox.Show("Войдите для завершения покупки");
                                        return;
                                   }
                                      
                                   if (ShoppingBasket.Count != 0)
                                   {
                                       if (_orderCity == "" || _orderAddress == "" || _orderCountry == "")
                                       {
                                           MessageBox.Show("Строки не могут быть пустыми");
                                           return;
                                       }

                                       Order = new();
                                       Order.OrderUserID = UserID;
                                       Order.OrderDate = DateTime.Now;
                                       Order.OrderAmount = _purchasePrice;
                                       Order.OrderCountry = _orderCountry;
                                       Order.OrderCity = _orderCity;
                                       Order.OrderAddress = _orderAddress;

                                       foreach (var product in ShoppingBasket)
                                       {
                                           orderdetail orderdetail = new();
                                           orderdetail.DetailsProductID = product.ProductID;
                                           Order.orderdetails.Add(orderdetail);
                                       }

                                       MainWindow.Market.orders.Add(Order);
                                       MainWindow.Market.SaveChanges();
                                       ShoppingBasket.Clear();
                                       PurchasePrice = 0.0;
                                       CountProductBasket = 0;
                                       ShowFrame = Visibility.Hidden;
                                       MessageBox.Show("Ваш заказ принят");

                                   }
                                   else
                                   {
                                       MessageBox.Show("Корзина пуста!");

                                   }
                               }));
                    }
                }
    }
}