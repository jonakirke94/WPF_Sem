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
using System.Windows.Shapes;
using WPF_SmartList.AuthService;

namespace WPF_SmartList
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void submit_login(object sender, RoutedEventArgs e)
        {

            var client = new AuthServiceClient();
            string email = txt_email.Text;
            string password = txt_password.Password.ToString();

            try
            {
                string token = client.LoginUser(email, password);

                if(!string.IsNullOrEmpty(token))
                {
                    Application.Current.Resources["Token"] = token;

                    //create main window and dispose current one
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();

                } else
                {
                    lbl_error.Content = "Invalid email or password";
                }


            }
            catch (Exception)
            {

               
            }
            finally
            {
                client.Close();
            }


        }
    }
}
