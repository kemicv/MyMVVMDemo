using Microsoft.Xaml.Behaviors.Core;
using MyMVVMDemo.Helpers;
using System.Windows;
using System.Windows.Input;

namespace MyMVVMDemo.ViewModels
{
    internal class SecondViewModel
    {
        public SecondViewModel()
        {
            SecClickCommand = new ActionCommand(ClickEvent);
        }

        public ICommand SecClickCommand { get; set; }
        private void ClickEvent()
        {
            MessageBox.Show("Sec ViewModel Function");
        }
    }
}
