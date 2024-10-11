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
using Project.Views;

namespace Project.ViewModels
{
    internal class ProfileViewModel : ViewModelBase
    {
        public RelayCommand MainCommand { get; private set; }
        public RelayCommand TicketCommand { get; private set; }
        public RelayCommand SupportCommand { get; private set; }
        public RelayCommand LogOutCommand { get; private set; }
        public RelayCommand CreditCardCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }
        public ProfileViewModel()
        {
            MainCommand = new RelayCommand(Main);
            TicketCommand = new RelayCommand(Ticket);
            SupportCommand = new RelayCommand(Support);
            LogOutCommand = new RelayCommand(LogOut);
            CreditCardCommand = new RelayCommand(CreditCard);
            CloseCommand = new RelayCommand(Close);
        }

        private void Main()
        {
            Home home = new Home();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(home);
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

        private void LogOut()
        {
            Login login = new Login();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(login);
        }
        private void CreditCard()
        {
            CreditCards creditCard = new CreditCards();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(creditCard);
        }
        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
