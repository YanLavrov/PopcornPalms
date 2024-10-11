using Project.Models;
using Project.Views;
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

namespace Project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        DataAccess db;
        public Login()
        {
            InitializeComponent();
            db = new DataAccess();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private async void LogIn()
        {
            try
            {
                var user = await db.FindUser(input_login.Text, input_password.Text);
                if (input_login.Text == "admin" || input_password.Text == "Admin")
                {
                    AdminMain adminMain = new AdminMain();
                    Frame mainFrame = Application.Current.MainWindow.Content as Frame;
                    mainFrame.NavigationService.Navigate(adminMain);
                }
                else if(user != null)
                {
                    TemporaryUser.Id = user.Id;
                    TemporaryUser.PIB = user.PIB;
                    TemporaryUser.Password = user.Password;

                    Home home = new Home();
                    Frame mainFrame = Application.Current.MainWindow.Content as Frame;
                    mainFrame.NavigationService.Navigate(home);
                }
                else
                {
                    MessageBox.Show("User not found", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogIn();
        }
    }
}
