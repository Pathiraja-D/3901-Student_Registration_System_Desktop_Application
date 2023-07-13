using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Desktop_3901
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static MainWindow Instance { get; private set; }
        public MainWindow()
        {
            Instance = this;
            DataContext = new MainWindowVM();
            InitializeComponent();
        }

        

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
