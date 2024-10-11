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
    internal class TicketViewModel : ViewModelBase
    {
        public RelayCommand MainCommand { get; private set; }
        public RelayCommand SupportCommand { get; private set; }
        public RelayCommand ProfileCommand { get; private set; }
        public RelayCommand BackCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public TicketViewModel()
        {
            MainCommand = new RelayCommand(Main);
            SupportCommand = new RelayCommand(Support);
            ProfileCommand = new RelayCommand(Profile);
            BackCommand = new RelayCommand(Back);
            CloseCommand = new RelayCommand(Close);
        }

        private void Main()
        {
            Home home = new Home();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(home);
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

        private void Back()
        {
            Home home = new Home();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(home);
        }
        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
