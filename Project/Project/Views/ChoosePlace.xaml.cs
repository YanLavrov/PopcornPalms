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
    /// Interaction logic for ChoosePlace.xaml
    /// </summary>
    /// 
    public partial class ChoosePlace : Page
    {
        private Dictionary<Button, bool> buttonStates = new Dictionary<Button, bool>();
        private string selectedTime = "";
        private string selectedRow = "";   
        private string selectedPlace = "";
        DataAccess db;
        public ChoosePlace()
        {
            InitializeComponent();
            db = new DataAccess();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;

            buttonStates[Butt21] = false;
            buttonStates[Butt22] = false;
            buttonStates[Butt23] = false;
            buttonStates[Butt24] = false;

            buttonStates[Butt41] = false;

            buttonStates[Butt51] = false;
            buttonStates[Butt52] = false;

            buttonStates[Butt61] = false;
            buttonStates[Butt62] = false;
            buttonStates[Butt63] = false;

            buttonStates[Butt71] = false;

            buttonStates[Button1] = false;
            buttonStates[Button2] = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In development...", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selectedTime = "12:00";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                Border1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1F2B"));
            }
            else
            {
                Border1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#700606"));
                Border2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1F2B"));
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            selectedTime = "14:00";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                Border2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1F2B"));
            }
            else
            {
                Border2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#700606"));
                Border1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1F2B"));
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
        }

        private int totalAmount = 0;
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            selectedRow = "2";
            selectedPlace = "2";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";  
                totalAmount -= 130;               
            }
            else
            {
                clickedButton.Content = "130";    
                totalAmount += 130;               
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

           totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt22_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "2";
            selectedPlace = "5";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";  
                totalAmount -= 130;               
            }
            else
            {
                clickedButton.Content = "130";    
                totalAmount += 130;               
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt23_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "2";
            selectedPlace = "6";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 130;
            }
            else
            {
                clickedButton.Content = "130";
                totalAmount += 130;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt24_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "2";
            selectedPlace = "7";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 130;
            }
            else
            {
                clickedButton.Content = "130";
                totalAmount += 130;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt41_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "4";
            selectedPlace = "2";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 130;
            }
            else
            {
                clickedButton.Content = "130";
                totalAmount += 130;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt51_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "5";
            selectedPlace = "3";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 150;
            }
            else
            {
                clickedButton.Content = "150";
                totalAmount += 150;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt52_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "5";
            selectedPlace = "4";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 150;
            }
            else
            {
                clickedButton.Content = "150";
                totalAmount += 150;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt61_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "6";
            selectedPlace = "3";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 150;
            }
            else
            {
                clickedButton.Content = "150";
                totalAmount += 150;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt62_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "6";
            selectedPlace = "4";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 150;
            }
            else
            {
                clickedButton.Content = "150";
                totalAmount += 150;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt63_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "6";
            selectedPlace = "5";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 150;
            }
            else
            {
                clickedButton.Content = "150";
                totalAmount += 150;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Butt71_Click(object sender, RoutedEventArgs e)
        {
            selectedRow = "7";
            selectedPlace = "3";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                clickedButton.Content = "";
                totalAmount -= 250;
            }
            else
            {
                clickedButton.Content = "250";
                totalAmount += 250;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];

            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Ticketss ticketss = new Ticketss("A Quiet Place: Day One", selectedRow, selectedPlace, selectedTime, "1");
            await db.CreateTicket(ticketss);

            Popcorn pop = new Popcorn(totalAmount);
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(pop);
        }
    }
}
