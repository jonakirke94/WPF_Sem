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
using WPF_SmartList.AuthService;

namespace WPF_SmartList.Pages
{
    /// <summary>
    /// Interaction logic for ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        private static List<User> UserList = new List<User>();
        private static List<Item> ItemList = new List<Item>();

        public ListPage(int listId)
        {
            InitializeComponent();
            InitListValues(listId);
        }

        public void InitListValues(int listId)
        {


            UserListView = new ListView {ItemsSource = UserList};
            ItemListView = new ListView {ItemsSource = ItemList};
        }
        
    }
}
