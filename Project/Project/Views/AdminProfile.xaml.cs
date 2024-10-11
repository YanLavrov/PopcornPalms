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

namespace Project.Views
{
    /// <summary>
    /// Interaction logic for AdminProfile.xaml
    /// </summary>

    public partial class AdminProfile : Page
    {
        DataAccess db;
        public AdminProfile()
        {
            InitializeComponent();
            db = new DataAccess();
            OutInfoUser();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private void OutInfoUser()
        {
            profileName.Content = "Admin";
            profileNumber.Content = "Admin";
        }
    }
}
