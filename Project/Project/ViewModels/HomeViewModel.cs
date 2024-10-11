using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Project.ViewModels
{
    internal class HomeViewModel : ViewModelBase
    {
        public RelayCommand TicketCommand { get; private set; }
        public RelayCommand SupportCommand { get; private set; }
        public RelayCommand ProfileCommand { get; private set; }
        public RelayCommand FilmCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public HomeViewModel()
        {
            TicketCommand = new RelayCommand(Ticket);
            SupportCommand = new RelayCommand(Support);
            ProfileCommand = new RelayCommand(Profile);
            FilmCommand = new RelayCommand(Film);
            CloseCommand = new RelayCommand(Close);
        }

        private void Ticket()
        {
            Tickets tickets = new Tickets();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(tickets);
        }

        private void Support()
        {
            Support support = new Support();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(support);
        }

        private void Profile()
        {
            Profile profile = new Profile();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(profile);
        }

        private void Film()
        {
            Description description = new Description();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(description);
        }
        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
