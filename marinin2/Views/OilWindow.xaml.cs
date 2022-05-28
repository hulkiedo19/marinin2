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
    /// Interaction logic for OilWindow.xaml
    /// </summary>
    public partial class OilWindow : Window
    {
        public OilWindow()
        {
            InitializeComponent();
        }

        private void BackToManager_Click(object sender, RoutedEventArgs e)
        {
            Window window = new ManagerWindow();
            window.Show();
            this.Close();
        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
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
