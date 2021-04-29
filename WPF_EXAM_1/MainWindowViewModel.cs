using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_EXAM_1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public DelegateCommand MyDelegate { get; set; }
        public string Text { get; set; }
        public int StartWidthValue { get; set; }
        public int StartHeightValue { get; set; }
        public int MaximumValue { get; set; }

        public int m_WidthValue;
        public int m_HeightValue;

        public int WidthValue
        {
            get
            {
                return this.m_WidthValue;
            }
            set
            {
                this.m_WidthValue = value;
                OnPropertyChanged("WidthValue");
            }
        }

        public int HeightValue
        {
            get
            {
                return this.m_HeightValue;
            }
            set
            {
                this.m_HeightValue = value;
                OnPropertyChanged("WidthValue");
            }
        }

        public MainWindowViewModel()
        {
            MyDelegate = new DelegateCommand(ExecuteCommand, CanExecuteMethod);
            StartHeightValue = 29;
            StartWidthValue = 110;
            Text = "I love WPF";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private bool CanExecuteMethod() { return true; }

        private void ExecuteCommand()
        {
            InfoWindow window = new InfoWindow(this);
            window.Show();
        }
    }
}
