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
    /// Interaction logic for Units.xaml
    /// </summary>
    public partial class Units : Page
    {
        public Units()
        {
            InitializeComponent();
            //BindDataGrid();
        }

        private void dg_units_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void BindDataGrid()
        //{
        //    var client = new ListServiceClient();
        //    try
        //    {


        //        var data = client.GetUnitData();

        //        dg_units.ItemsSource = data;

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
