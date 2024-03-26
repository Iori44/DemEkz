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

namespace Useers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = (from Users in zxcEntities.GetContext().Users where Users.Login == tbLogin.Text && Users.Passwowrd == tbPassword.Password select Users).First();

                
                    if (query.Login == "admin1") 
                    
                    {
                        Admin adminWindow = new Admin();
                        adminWindow.Show();
                    }
                    else
                    {
                        // Show User Window
                        User userWindow = new User();
                        userWindow.Show();
                    }
                    this.Close();
                
                
            }
            catch 
            {
                MessageBox.Show("An error occurred:");
            }
        }

        private void LoginWindow_Closed(object sender, EventArgs e)
        {

        }
    }
}
