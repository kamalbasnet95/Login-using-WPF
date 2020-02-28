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

namespace Payroll_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
        }
        
        private void User_Click(object sender, RoutedEventArgs e)
        {
           
            //Window1 useracct = new Window1 { Owner = this };
            //useracct.ShowInTaskbar = false;
            ///useracct.Owner = Application.Current.MainWindow;
           // useracct.Show();
          

        }
    }
}
