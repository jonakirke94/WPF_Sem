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

namespace WPF_SmartList
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class Categories : Page
    {
        public Categories()
        {
            InitializeComponent();
            //BindDataGrid();
        }

        private void dg_categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void BindDataGrid()
        //{
        //   // string token = Application.Current.Resources["Token"].ToString();
        //    var client = new ListServiceClient();
        //    try
        //    {


        //        var data = client.GetMostUsedCategories();

        //        dg_categories.ItemsSource = data;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        client.Close();
        //    }
        //}
    }
}
