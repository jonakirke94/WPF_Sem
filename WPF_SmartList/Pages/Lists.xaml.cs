using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPF_SmartList.ListService;
//using WPF_SmartList.ListService;

namespace WPF_SmartList.Pages
{
    /// <summary>
    /// Interaction logic for Lists.xaml
    /// </summary>
    public partial class Lists : Page
    {
        private List<StatsControllerLightListData> obCol = new List<StatsControllerLightListData>();

        public Lists()
        {
            InitializeComponent();
            BindDataGrid();

            
        }

        private void filter_clicked(object sender, RoutedEventArgs e)
        {
            string input = txt_filter.Text;

            if (!string.IsNullOrEmpty(input) && Int32.TryParse(input, out int id))
            {

                // Collection which will take the list
                var _itemSourceList = new CollectionViewSource() { Source = obCol };

                // ICollectionView the View/UI part 
                ICollectionView Itemlist = _itemSourceList.View;

                // costumFilter
                var costumFilter = new Predicate<object>(item => ((StatsControllerLightListData)item).ListId == id);

                Itemlist.Filter = costumFilter;

                dg_list.ItemsSource = Itemlist;

            }

           


        }

        private void showAll_clicked(object sender, RoutedEventArgs e)
        {
            dg_list.ItemsSource = obCol;

        }

        private void dg_lists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BindDataGrid()
        {
            //    string token = Application.Current.Resources["Token"].ToString();
            var client = new ListServiceClient();
            try
            {


                List<StatsControllerLightListData> data = client.GetLists();
                obCol = data;
                dg_list.ItemsSource = data;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                client.Close();
            }
        }

        //method for redirecting to correct list page
        private void GoToList_clicked(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = dg_list;
            DataGridRow Row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowAndColumn = (DataGridCell)dataGrid.Columns[0].GetCellContent(Row).Parent;
            string CellValue = ((TextBlock)RowAndColumn.Content).Text;
        }
     }
}
