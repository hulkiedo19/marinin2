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
using System.Windows.Shapes;

namespace marinin2.Views
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void Accumulators_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AccumulatorWindow();
            window.Show();
            this.Close();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AdminWindow();
            window.Show();
            this.Close();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CustomerWindow();
            window.Show();
            this.Close();
        }

        private void Disks_Click(object sender, RoutedEventArgs e)
        {
            Window window = new DisksWindow();
            window.Show();
            this.Close();
        }

        private void Oils_Click(object sender, RoutedEventArgs e)
        {
            Window window = new OilWindow();
            window.Show();
            this.Close();
        }

        private void Tires_Click(object sender, RoutedEventArgs e)
        {
            Window window = new TiresWindow();
            window.Show();
            this.Close();
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            Window window = new LoginWindow();
            window.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
