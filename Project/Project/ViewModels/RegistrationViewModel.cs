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
    internal class RegistrationViewModel : ViewModelBase
    {
        public RelayCommand GoogleAuth { get; private set; }
        public RelayCommand FacebookAuth { get; private set; }
        public RelayCommand AppleAuth { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public RegistrationViewModel()
        {
            GoogleAuth = new RelayCommand(Google);
            FacebookAuth = new RelayCommand(Facebook);
            AppleAuth = new RelayCommand(Apple);
            CloseCommand = new RelayCommand(Close);
        }

        private void Google()
        {
            Login login = new Login();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(login);
        }

        private void Facebook()
        {
            Login login = new Login();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(login);
        }

        private void Apple()
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
