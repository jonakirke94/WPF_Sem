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
    /// Interaction logic for General.xaml
    /// </summary>
    public partial class General : Page
    {
        public General()
        {
            InitializeComponent();
            SetGeneralStats();
        }

        private void SetGeneralStats()
        {
            //string token = Application.Current.Resources["Token"].ToString();
            //var client = new ListServiceClient();
            //try
            //{               
            //    var stats = client.GetGeneralStats(token);

            //    lbl_totaluser.Content = stats.TotalUserCount;
            //    lbl_totalLists.Content = stats.TotalListCount;
            //    lbl_totalProducts.Content = stats.TotalItemCount;
            //}
            //catch (Exception)
            //{
            //}
            //finally
            //{
            //    client.Close();
            //}

        }
    }
}
