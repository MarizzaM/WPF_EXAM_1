using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_EXAM_1
{
    /// <summary>
    /// Interaction logic for LimitedInputUserControl.xaml
    /// </summary>
    public partial class LimitedInputUserControl : UserControl, INotifyPropertyChanged
    {
        public string Title { get; set; }
        public int StartValue { get; set; }
        public int MaximumValue { get; set; }
        public DelegateCommand MyDelegate { get; set; }
        private MainWindow mw;

        public int m_value;

        public int Value
        {
            get
            {
                return this.m_value;
            }
            set
            {
                this.m_value =value;
                OnPropertyChanged("Value");
            }
        }

        public LimitedInputUserControl()
        {
            InitializeComponent();
            this.DataContext = this;

            MyDelegate = new DelegateCommand(ExecuteCommand, CanExecuteMethod);

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
            DescriptionWindow dw = new DescriptionWindow(mw);
            dw.ShowDialog();

        }
    }
}
