using System.Windows;
using System.Windows.Input;

namespace Lab_06_07_OOP.UI
{
    using System.Windows.Input;
 
    public class WindowCommands
    {
        static WindowCommands()
        {
            ChoseLang = new RoutedCommand("ChoseLang", typeof(MainWindow));
        }
        
        public static RoutedCommand ChoseLang { get; set; }


    }
}