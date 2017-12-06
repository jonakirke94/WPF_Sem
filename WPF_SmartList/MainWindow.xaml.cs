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
using WPF_SmartList.Pages;

namespace WPF_SmartList
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

        private void general_clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new General();

        }

        private void categories_clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Categories();
        }

        private void home_clicked(object sender, RoutedEventArgs e)
        {
            //redirect to home
           
        }

        private void units_clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Units();
        }

        private void lists_clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Lists();
        }
    }
}
