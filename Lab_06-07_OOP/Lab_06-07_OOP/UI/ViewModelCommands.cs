﻿using System;
using System.Windows.Input;

namespace Lab_06_07_OOP.UI
{
    public class ViewModelCommands : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
 
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
 
        public ViewModelCommands(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
 
        public bool CanExecute(object parameter)
        {
            return canExecute == null || this.canExecute(parameter);
        }
 
        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}