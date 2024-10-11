using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        DataAccess access;
        public Profile()
        {
            InitializeComponent();
            access = new DataAccess();
            OutInfoUser();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private async void OutInfoUser()
        {
            var user = await access.OutUser(TemporaryUser.Id);
            if (user != null)
            {
                profileName.Content = user.PIB;
                profileNumber.Content = "+" + user.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Користувача не знайдено", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
