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

namespace FreeFreelancer
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
        private void Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up page = new Sign_Up();
            page.Show();
            this.Hide();
        }

        private void Log_In_Click(object sender, RoutedEventArgs e)
        {
            Home page = new Home();
            page.Show();
            this.Hide();
        }
    }
}
