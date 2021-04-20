using System.Windows;
using System.Windows.Input;

namespace Lab_06_07_OOP.UI
{
    using System.Windows.Input;
 
    public class WindowCommands
    {
        static WindowCommands()
        {
            Add = new RoutedCommand("Add", typeof(MainWindow));
            Info = new RoutedCommand("Info", typeof(MainWindow));
            Del = new RoutedCommand("Del", typeof(MainWindow));
        }
        public static RoutedCommand Add { get; set; }
        public static RoutedCommand Info { get; set; }
        public static RoutedCommand Del { get; set; }
    }
}