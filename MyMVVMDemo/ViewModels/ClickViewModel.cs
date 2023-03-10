using Microsoft.Xaml.Behaviors.Core;
using MyMVVMDemo.Helpers;
using MyMVVMDemo.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyMVVMDemo.ViewModels
{
    internal class ClickViewModel 
    {
        public ClickViewModel()
        {
            ClickCommand = new ActionCommand(ClickEvent);
            modelo = new Counter();
            DecrementCmd = new ActionCommand(Decrement);
            IncrementCmd = new ActionCommand(Increment);
            TxtChangedCommand = new ActionCommand(TxtUpdated);
            MyCommand = new ActionCommand(OnCommandExecuted);
        }

        #region MANEJO DE CLICK EVENTS (Commands)
        public ICommand ClickCommand { get; set; }
        private void ClickEvent()
        {
            MessageBox.Show("This is a Click Event");
        }
        #endregion

        #region ACCEDIENDO A LOS MODELOS
        public Counter modelo { get; set; }
        public ICommand DecrementCmd { get; set; }
        public ICommand IncrementCmd { get; set; }

        private void Decrement() { modelo.Contador--; }
        private void Increment() { modelo.Contador++; }
        #endregion

        #region MANEJO DE TEXT-CHANGED
        public ICommand TxtChangedCommand { get; set; }
        private void TxtUpdated()
        {
            MessageBox.Show("You update the text");
        }
        #endregion

        #region PARAMETERS
        public ICommand MyCommand { get; set; }
        public void OnCommandExecuted(object obj)
        {
            //var button = obj as Button;
            //button.Content = "cahngw";
            //MessageBox.Show(button.Content.ToString());
            MessageBox.Show(obj.ToString());
        }
        #endregion
    }
}
