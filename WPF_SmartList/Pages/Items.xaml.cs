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
//using WPF_SmartList.ListService;

namespace WPF_SmartList.Pages
{
    /// <summary>
    /// Interaction logic for Items.xaml
    /// </summary>
    public partial class Items : Page
    {
        public Items()
        {
            InitializeComponent();
        }

        private void details_clicked(object sender, RoutedEventArgs e)
        {
            //var id = lbl_id.Text();
            //temp
            var id = 1;
            NavigationService.Navigate(new Uri(@"Pages/ItemDetails.xaml", System.UriKind.RelativeOrAbsolute), id);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //var client = new ListServiceClient();
            ////var textinput = Txt_search.
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}
