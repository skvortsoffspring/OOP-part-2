using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using Lab_06_07_OOP.Patterns;
using Lab_06_07_OOP.UI;

namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel : IDataErrorInfo
    {
        private Memento _memento;
        private string _errorMsg;
        private string _email = "";
        private string _phone = "";
        private string _password = "";
        private string _passwordRepeat = "";
        private string _inOutString = "Войти";
        private ViewModelCommands _goLogging;
        private ViewModelCommands _goRegister;
        private double _adminPanel = 0.0;
        private double _sizeBoxComment = 0.0;
        private IDataErrorInfo _dataErrorInfoImplementation;
        private ViewModelCommands _showFormLogin;
        private TimerCallback _timerCallback;
        private Timer _timer;
        private Visibility _visibleFormRegistered = Visibility.Hidden;
        public string Error => _dataErrorInfoImplementation.Error;
        public string UserEmail { get; set; }

        public Visibility VisibleFormRegistered
        {
            get => _visibleFormRegistered;
            set
            {
                _visibleFormRegistered = value;
                OnPropertyChanged("VisibleFormRegistered");
            }
        }
        public double SizeBoxComment
        {
            get => _sizeBoxComment;
            set
            {
                _sizeBoxComment = value;
                OnPropertyChanged("SizeBoxComment");
            }
        }
        public int UserID { get; set; }

        public double AdminPanel
        {
            get => _adminPanel;
            set
            {
                _adminPanel = value;
                OnPropertyChanged("AdminPanel");
            }
        }
        public string InOutString
        {
            get => _inOutString;
            set {
                _inOutString = value;
                OnPropertyChanged("InOutString");
            }
        }
        public string ErrorMsg
        {
            get => _errorMsg; 
            set { 
                _errorMsg = value;
                OnPropertyChanged("ErrorMsg");
            }
        }
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
            }
        }
        public string PasswordRepeat
        {
            get => _passwordRepeat;
            set => _passwordRepeat = value;
        }
        
        public string this[string columnName]
        {
            get
            {
                ErrorMsg = "";
                switch (columnName)
                {
                    case "Email":
                        if (string.IsNullOrEmpty(Email))
                        {
                            ErrorMsg = "";
                            return ErrorMsg;
                        }
                        if (!Regex.IsMatch(Email,
                                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                            ErrorMsg = "Неверный формат почты";
                        break;
                    case "Password":
                        if (string.IsNullOrEmpty(Password))
                        {
                            ErrorMsg = "";
                            return ErrorMsg;
                        }
                        if (Password.Length < 8)
                            ErrorMsg = "Пароль меньше 8 символов";
                        break;
                    case "PasswordRepeat":
                        if (string.IsNullOrEmpty(PasswordRepeat))
                        {
                            ErrorMsg = "";
                            return ErrorMsg;
                        }
                        if(PasswordRepeat.Length < 8)
                        {
                            ErrorMsg = "Пароль меньше 8 символов";
                            return ErrorMsg;
                        }
                        if (Password != PasswordRepeat)
                            ErrorMsg = "Пароли не совпадают";
                        break;
                    case "Phone":
                        if (string.IsNullOrEmpty(Phone))
                        {
                            ErrorMsg = "";
                            return ErrorMsg;
                        }
                        if (!Regex.IsMatch(Phone,
                            @"^(\+375)\((29|25|44|33)\)(\d{3})(\-\d{2})(\-\d{2})$",
                            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                            ErrorMsg = "+375(xx)xxx-xx-xx";
                        break;
                }
                
                return ErrorMsg;
            }
           
        }
        public ViewModelCommands GoLogging
        {
            get
            {
                return _goLogging ??
                       (_goLogging = new ViewModelCommands(obj =>
                       {
                           user user = new user();
                           user.UserEmail = _email;

                           var foundUser =
                                MainWindow.Market.users.SqlQuery(
                                   "select * from users where UserEmail = '"+ Email +"' and UserPassword = '" + Password.GetHashCode() + "'").ToList();

                           if (foundUser.Count!=0)
                           {
                                user = foundUser.First() ;
                                UserEmail = user.UserEmail;
                                UserID = user.UserID;
                                MainWindow.Role = user.Role;
                                InOutString = "Выйти";
                                MainWindow.Entered = true;
                                CheckRole();
                                VisibleFormRegistered = Visibility.Hidden;
                           }
                           else
                           {
                               ErrorMsg = "Неверный логин или пароль";
                           }
                       }));
            }
        }
        public ViewModelCommands GoRegister
        {
            get
            {
                return _goRegister ??
                       (_goRegister = new ViewModelCommands(obj =>
                       {
                           if (Password == PasswordRepeat && Password.Length!=0 && ErrorMsg=="")
                           {
                               var user = new user();
                               user.UserEmail = _email;
                               user.UserPassword = _password.GetHashCode().ToString();
                               var phone = string.Empty;

                               foreach (var c in _phone)
                               {
                                   if (char.IsDigit(c))
                                       phone += c;
                               }

                               user.UserPhone = Decimal.Parse(phone);
                               user.UserRegistrationDate = DateTime.Now;
                               user.Role = 0;
                               MainWindow.Market.users.Add(user);
                               MainWindow.Market.SaveChangesAsync();
                               VisibleFormRegistered = Visibility.Hidden;
                           }
                           else
                           {
                               ErrorMsg = "Пароли не совпадают";
                           }
                           
                       }));
            }
        }
        public ViewModelCommands ShowFormLogin
        {
            get
            {
                return _showFormLogin ?? 
                       (_showFormLogin = new ViewModelCommands(obj =>
                       {

                           if (VisibleFormRegistered == Visibility.Hidden)
                           {
                               VisibleFormRegistered = Visibility.Visible;
                               MainWindow.Entered = false;
                               InOutString = "Войти";
                               UserEmail = "";
                               MainWindow.Role = 0;
                               CheckRole();
                           }
                           else
                           {
                               VisibleFormRegistered = Visibility.Hidden;
                           }

                       }));
            }
        } 

        private void CheckRole()
        {
            if (MainWindow.Role == 1)
            {
                AdminPanel = 400.0;
                _memento = new Memento(SelectedProduct);
                _timerCallback = _memento.Backup;
                _timer = new Timer(_timerCallback, 0, 0, 5000);
            }
            else if (MainWindow.Role == 2)
            {
                if(_timer!=null)
                    _timer.Dispose();
                AdminPanel = 400.0;
                SelectPage.Execute("delivery");
            }
            else
            {
                if(_timer!=null)
                    _timer.Dispose();
                AdminPanel = 0.0;
            }
        }
    }
}