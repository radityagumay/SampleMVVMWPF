using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace SampleCalendarWPF
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand SelectedDateChangeCommand { get; private set; }
        

        public MainWindowViewModel() 
        {
            this.SelectedDateChangeCommand = new DelegateCommand(SaveCommand_Execute, SaveCommand_CanExecute);
        }

        private void SaveCommand_Execute(object arg)
        {
            Debug.Write("raditya gumay SaveCommand_Execute");
        }

        private bool SaveCommand_CanExecute(object arg)
        {
            Debug.Write("raditya gumay SaveCommand_CanExecute");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
