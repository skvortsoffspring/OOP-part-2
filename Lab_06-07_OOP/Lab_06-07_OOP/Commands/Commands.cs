using System.Windows;
using System.Windows.Input;

namespace Lab_06_07_OOP.UI
{
    using System.Windows.Input;
 
    public class WindowCommands
    {
        static WindowCommands()
        {
            HiddenLogging = new RoutedCommand("HiddenLogging", typeof(MainWindow));
        }
        
        public static RoutedCommand HiddenLogging { get; set; }


    }
}