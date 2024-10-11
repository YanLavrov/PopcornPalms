using Project.Models;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        DataAccess db;
        public Registration()
        {
            InitializeComponent();
            db = new DataAccess();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }


        private async void Registrations()
        {
            try
            {
                User user = new User(input_name.Text, input_login.Text, input_number.Text, input_password.Text);

                await db.CreateUser(user);
                TemporaryUser.Id = user.Id;
                TemporaryUser.PIB = user.PIB;
                TemporaryUser.Login = user.Login;
                TemporaryUser.PhoneNumber = user.PhoneNumber;
                TemporaryUser.Password = user.Password;

                Home home = new Home();
                Frame mainFrame = Application.Current.MainWindow.Content as Frame;
                mainFrame.NavigationService.Navigate(home);
            }
            catch (Exception er)
            {
                MessageBox.Show("Такий логін вже використовується", "Попередження", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registrations();
        }
    }
}
