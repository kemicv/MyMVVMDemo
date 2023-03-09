using MyMVVMDemo.Helpers;
using System.Windows;

namespace MyMVVMDemo.ViewModels
{
    internal class SecondViewModel
    {
        public SecondViewModel()
        {
            secClickCommand = new RelayCommand(ClickEvent);
        }

        private RelayCommand secClickCommand;
        public RelayCommand SecClickCommand
        {
            get { return secClickCommand; }
        }
        private void ClickEvent()
        {
            MessageBox.Show("Sec ViewModel Function");
        }
    }
}
