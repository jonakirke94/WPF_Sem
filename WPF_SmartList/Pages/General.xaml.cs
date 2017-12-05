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

            try
            {
                //var client = new ListServiceClient();



                //lbl_totaluser.Content = client.GetTotalUsers(token);
                //lbl_totalLists.Content = client.GetTotalLists(token);
                //lbl_totalProducts.Content = client.GetTotalProducts(token);
            }
            catch (Exception)
            {
            }
            finally
            {
                //client.Close();
            }

        }
    }
}
