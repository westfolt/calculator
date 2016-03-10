using System;
using System.Collections.Generic;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        #region Delegates

        private EventHandler numberClick;
        private EventHandler actionClick;
        private EventHandler pointClick;
        private EventHandler equalsClick;
        private EventHandler cancelClick;

        #endregion

        #region Events

        public event EventHandler NumberClick
        {
            add { numberClick += value; }
            remove { numberClick -= value; }
        }

        public event EventHandler ActionClick
        {
            add { actionClick += value; }
            remove { actionClick -= value; }
        }

        public event EventHandler PointClick
        {
            add { pointClick += value; }
            remove { pointClick -= value; }
        }

        public event EventHandler EqualsClick
        {
            add { equalsClick += value; }
            remove { equalsClick -= value; }
        }
        public event EventHandler CancelClick
        {
            add { cancelClick += value; }
            remove { cancelClick -= value; }
        }

        #endregion

        #region Methods
        private void NumbersButtons_Click(object sender, RoutedEventArgs e)
        {
            numberClick.Invoke(sender, e);
        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            equalsClick.Invoke(sender, e);
        }
        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            pointClick.Invoke(sender, e);
        }
        private void ActionButton_Click(object sender, RoutedEventArgs e)
        {
            actionClick.Invoke(sender, e);
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            cancelClick.Invoke(sender, e);
        }
        #endregion

    }
}
