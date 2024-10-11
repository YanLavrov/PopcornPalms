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
    internal class SupportViewModel : ViewModelBase
    {
        public RelayCommand MainCommand { get; private set; }
        public RelayCommand TicketCommand { get; private set; }
        public RelayCommand ProfileCommand { get; private set; }
        public RelayCommand BackCommand { get; private set; }
        public RelayCommand SendCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }


        public SupportViewModel()
        {
            MainCommand = new RelayCommand(Main);
            TicketCommand = new RelayCommand(Ticket);
            ProfileCommand = new RelayCommand(Profile);
            BackCommand = new RelayCommand(Back);
            SendCommand = new RelayCommand(Send);
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

        private void Profile()
        {
            Profile profile = new Profile();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(profile);
        }

        private void Back()
        {
            Home home = new Home();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(home);
        }

        private void Send()
        {
            MessageBox.Show("Message sent", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
