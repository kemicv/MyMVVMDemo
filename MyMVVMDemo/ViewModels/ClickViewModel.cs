using MyMVVMDemo.Helpers;
using MyMVVMDemo.Models;
using System.Windows;

namespace MyMVVMDemo.ViewModels
{
    internal class ClickViewModel : BaseINotify
    {
        public ClickViewModel()
        {
            clickCommand = new RelayCommand(ClickEvent);
            modelo = new Counter();
            decrementCmd = new RelayCommand(Decrement);
            incrementCmd = new RelayCommand(Increment);
            txtChangedCmd = new RelayCommand(TxtUpdated);
        }

        #region MANEJO DE CLICK EVENTS (Commands)
        private RelayCommand clickCommand;
        public RelayCommand ClickCommand
        {
            get { return clickCommand; }
        }
        private void ClickEvent()
        {
            MessageBox.Show("This is a Click Event");
        }
        #endregion

        #region ACCEDIENDO A LOS MODELOS
        public Counter modelo { get; set; }
        private RelayCommand decrementCmd;
        private RelayCommand incrementCmd;
        public RelayCommand DecrementCmd { get { return decrementCmd; } }
        public RelayCommand IncrementCmd { get { return incrementCmd; } }

        private void Decrement()
        {
            modelo.Contador--;
        }
        private void Increment()
        {
            modelo.Contador++;
        }
        #endregion

        #region MANEJO DE TEXT-CHANGED 
        private RelayCommand txtChangedCmd;
        public RelayCommand TxtChangedCommand
        {
            get { return txtChangedCmd; }
        }
        private void TxtUpdated()
        {
            MessageBox.Show("You update the text");
        }
        #endregion
    }
}
