using System;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Views.ViewModel
{
    class MyCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Predicate<object> ExecuteChanged { get; set; }

        public bool CanExecute(object? parameter)
        {
            if (ExecuteChanged != null)
            {
                return ExecuteChanged(parameter);
            }
            return true;
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show("Hello World");
        }
    }
}
