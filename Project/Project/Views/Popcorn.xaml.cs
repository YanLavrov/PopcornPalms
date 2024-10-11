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
    /// Interaction logic for Popcorn.xaml
    /// </summary>
    public partial class Popcorn : Page
    {
        private Dictionary<Button, bool> buttonStates = new Dictionary<Button, bool>();
        private int totalAmount;
        DataAccess db;

        private string selectedPopcorn = "";
        private string selectedFlavor = "";
        private string selectedPrice = "";

        public Popcorn(int currentAmount)
        {
            InitializeComponent();
            db = new DataAccess();


            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;


            buttonStates[Butt1L] = false;
            buttonStates[Butt3L] = false;
            buttonStates[Butt5L] = false;

            buttonStates[Caramel] = false;
            buttonStates[Fruit] = false;
            buttonStates[Cheese] = false;
            buttonStates[Bacon] = false;

            totalAmount = currentAmount;
            totalLabel.Content = totalAmount.ToString() + " UAH";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectedPopcorn = "1.5L";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                l1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                totalAmount -= 80;
            }
            else
            {
                l1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                l3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                l5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                totalAmount += 80;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
            totalLabel.Content = totalAmount.ToString() + " UAH";
            selectedPrice = totalAmount.ToString();
        }

        private void Butt3L_Click(object sender, RoutedEventArgs e)
        {
            selectedPopcorn = "3L";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                l3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                totalAmount -= 150;
            }
            else
            {
                l3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                l1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                l5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                totalAmount += 150;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
            totalLabel.Content = totalAmount.ToString() + " UAH";
            selectedPrice = totalAmount.ToString();
        }

        private void Butt5L_Click(object sender, RoutedEventArgs e)
        {
            selectedPopcorn = "5L";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                l5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                totalAmount -= 220;
            }
            else
            {
                l5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                l1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                l3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
                totalAmount += 220;
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
            totalLabel.Content = totalAmount.ToString() + " UAH";
            selectedPrice = totalAmount.ToString();
        }

        private void Caramel_Click(object sender, RoutedEventArgs e)
        {
            selectedFlavor = "Caramel";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                Caramel.Background = new SolidColorBrush(Colors.Transparent);
                Caramel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }
            else
            {
                Caramel.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                Caramel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#830404"));

                Cheese.Background = new SolidColorBrush(Colors.Transparent);
                Cheese.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Fruit.Background = new SolidColorBrush(Colors.Transparent);
                Fruit.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Bacon.Background = new SolidColorBrush(Colors.Transparent);
                Bacon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
        }

        private void Fruit_Click(object sender, RoutedEventArgs e)
        {
            selectedFlavor = "Fruit";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                Fruit.Background = new SolidColorBrush(Colors.Transparent);
                Fruit.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }
            else
            {
                Fruit.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                Fruit.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#830404"));

                Caramel.Background = new SolidColorBrush(Colors.Transparent);
                Caramel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Cheese.Background = new SolidColorBrush(Colors.Transparent);
                Cheese.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Bacon.Background = new SolidColorBrush(Colors.Transparent);
                Bacon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
        }

        private void Cheese_Click(object sender, RoutedEventArgs e)
        {
            selectedFlavor = "Cheese";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                Cheese.Background = new SolidColorBrush(Colors.Transparent);
                Cheese.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }
            else
            {
                Cheese.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                Cheese.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#830404"));

                Caramel.Background = new SolidColorBrush(Colors.Transparent);
                Caramel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Fruit.Background = new SolidColorBrush(Colors.Transparent);
                Fruit.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Bacon.Background = new SolidColorBrush(Colors.Transparent);
                Bacon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
        }

        private void Bacon_Click(object sender, RoutedEventArgs e)
        {
            selectedFlavor = "Bacon";

            Button clickedButton = sender as Button;

            if (buttonStates[clickedButton])
            {
                Bacon.Background = new SolidColorBrush(Colors.Transparent);
                Bacon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }
            else
            {
                Bacon.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));
                Bacon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#830404"));

                Caramel.Background = new SolidColorBrush(Colors.Transparent);
                Caramel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Fruit.Background = new SolidColorBrush(Colors.Transparent);
                Fruit.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));

                Cheese.Background = new SolidColorBrush(Colors.Transparent);
                Cheese.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#887A7A"));
            }

            buttonStates[clickedButton] = !buttonStates[clickedButton];
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Popcorns popcorns = new Popcorns(selectedPopcorn, selectedFlavor, selectedPrice);

            TemporaryPopcorn.PopcornVolume = selectedPopcorn;
            TemporaryPopcorn.PopcornFlavor = selectedFlavor;
            TemporaryPopcorn.TotalPrice = selectedPrice;
            await db.CreatePopcorn(popcorns);

            Payment payment = new Payment();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(payment);
        }
    }
}
