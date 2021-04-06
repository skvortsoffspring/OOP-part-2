using System.Windows;
using System.Windows.Input;

namespace Lab_06_07_OOP.UI
{
    public class CustomCommandSample : Window
    {
        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

    public static class CustomCommands
    {
        public static readonly RoutedUICommand Info = new RoutedUICommand
        (
            "Info",
            "Info",
            typeof(CustomCommands)
        );
        
        public static readonly RoutedUICommand ADd = new RoutedUICommand
        (
            "Add",
            "Add",
            typeof(CustomCommands)
        );


        //Define more commands here, just like the one above
    }
}