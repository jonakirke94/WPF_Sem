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

namespace WPF_SmartList.Pages
{
    /// <summary>
    /// Interaction logic for ItemDetails.xaml
    /// </summary>
    public partial class ItemDetails : Page
    {
        public ItemDetails()
        {
            

            InitializeComponent();

            
            //navigationservice currently is null --- may be error in method of redirecting
            //this subscribes the event handler 
            NavigationService.LoadCompleted += NavigationService_LoadCompleted;

            

        }

        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            string str = (string)e.ExtraData;
            lbl_test.Content = str;
            // do whatever with str, like assign to a view model field, etc.
        }
    }
}
