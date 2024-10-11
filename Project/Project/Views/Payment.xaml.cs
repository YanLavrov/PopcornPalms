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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Page
    {
        DataAccess db;
        public Payment()
        {
            InitializeComponent();
            db = new DataAccess();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;

            
            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CardNumberInput.Text == "" || ValidUntilInput.Text == "" || CVVInput.Text == "" || CardHolderInput.Text == "")
                {
                    MessageBox.Show("Not all fields are filled in", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    Card card = new Card(CardNumberInput.Text, ValidUntilInput.Text, CVVInput.Text, CardHolderInput.Text);

                    TemporaryCard.Id = card.Id;
                    TemporaryCard.CardNumber = CardNumberInput.Text;
                    TemporaryCard.ValidUntil = ValidUntilInput.Text;
                    TemporaryCard.CVV = CVVInput.Text;
                    TemporaryCard.CardHolder = CardHolderInput.Text;

                    await db.CreateCard(card);
                    MessageBox.Show("Successful payment", "Successfuly", MessageBoxButton.OK, MessageBoxImage.Information);
                    Tickets ticket = new Tickets();
                    Frame mainFrame = Application.Current.MainWindow.Content as Frame;
                    mainFrame.NavigationService.Navigate(ticket);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("asdasda");

            }
        }
        private void TextChanged1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CardNumberLabel.Content = CardNumberInput.Text;
        }
        private void TextChanged2(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ValidTHRULabel.Content = ValidUntilInput.Text;
        }
        private void TextChanged3(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CVVLabel.Content = CVVInput.Text;
        }
        private void TextChanged4(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CardHolderLabel.Content = CardHolderInput.Text;
        }
        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            MonobankPhoto.Source = new BitmapImage(new Uri("D:/Универ/4 курс/1 семестр/ТСПП (Котик)/PopcornPalms/Project/Project/Photos/CreditCardBack.png", UriKind.Absolute));
            CardNumberLabel.Visibility = Visibility.Hidden;
            ValidTHRULabel.Visibility = Visibility.Hidden;
        }
    }
}

