using System;
using System.Windows.Input;

namespace MyMVVMDemo.Helpers
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action DoWork;

        public RelayCommand(Action TypeWork)
        {
            DoWork = TypeWork;
        }
        public RelayCommand(Action TypeWork, KeyEventArgs e)
        {
            DoWork = TypeWork;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoWork();
        }
    }
}
