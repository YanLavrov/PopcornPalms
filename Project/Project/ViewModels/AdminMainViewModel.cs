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
    internal class AdminMainViewModel
    {
        public RelayCommand MianCommand { get; private set; }
        public RelayCommand ProfileCommand { get; private set; }
        public RelayCommand LogOutCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public AdminMainViewModel()
        {
            MianCommand = new RelayCommand(Main);
            ProfileCommand = new RelayCommand(Profile);
            LogOutCommand = new RelayCommand(LogOut);
            CloseCommand = new RelayCommand(Close);
        }

        private void Main()
        {
            AdminMain main = new AdminMain();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(main);
        }

        private void Profile()
        {
            AdminProfile profile = new AdminProfile();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(profile);
        }
        private void LogOut()
        {
            Login login = new Login();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(login);
        }

        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
