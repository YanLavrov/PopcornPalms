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
    /// Interaction logic for Tickets.xaml
    /// </summary>
    public partial class Tickets : Page
    {
        DataAccess access;
        public Tickets()
        {
            InitializeComponent();
            access = new DataAccess();
            OutInfoticket();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private async void OutInfoticket()
        {
            var ticket = await access.OutTicket("A Quiet Place: Day One");
            if(ticket != null)
            {
                NameFilm.Content = ticket.NameofTicket;
                RowFilm.Content = ticket.Row;
                TimeFilm.Content = ticket.Time;
                PlaceFilm.Content = ticket.Place;
                IdTicket.Content = ticket.NumberTicket;
                PriceFilm.Content = TemporaryPopcorn.TotalPrice + " UAH";
                PopcornFilm.Content = TemporaryPopcorn.PopcornVolume;
            }
            else
            {
                TicketImage1.Visibility = Visibility.Hidden;
                TicketImage.Visibility = Visibility.Hidden;
                LabelCinema.Visibility = Visibility.Hidden;
                LabelDate.Visibility = Visibility.Hidden;
                LabelRow.Visibility = Visibility.Hidden;
                LabelPrice.Visibility = Visibility.Hidden;
                LabelId.Visibility = Visibility.Hidden;
                LabelTime.Visibility = Visibility.Hidden;
                LabelPlace.Visibility = Visibility.Hidden;
                LabelPopcorn.Visibility = Visibility.Hidden;
                LabelTire.Visibility = Visibility.Hidden;
                PolosaImage.Visibility = Visibility.Hidden;
                BarCode.Visibility = Visibility.Hidden;
                MessageBox.Show("Ticket not found", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
