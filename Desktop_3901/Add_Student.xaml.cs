using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop_3901
{
    /// <summary>
    /// Interaction logic for Add_Student.xaml
    /// </summary>
    public partial class Add_Student : Window
    {
        

        public Add_Student(Add_StudentVM VMpara)
        {
            
            InitializeComponent();
            DataContext = VMpara;
            VMpara.CloseAction =()=>Close();
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();  
        }
    }
}
