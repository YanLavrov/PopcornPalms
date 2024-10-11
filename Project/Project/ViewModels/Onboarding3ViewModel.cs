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
    internal class Onboarding3ViewModel : ViewModelBase
    {
        public RelayCommand ContinueCommand { get; private set; }
        public RelayCommand SkipCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public Onboarding3ViewModel()
        {
            ContinueCommand = new RelayCommand(Continue);
            SkipCommand = new RelayCommand(Skip);
            CloseCommand = new RelayCommand(Close);
        }

        private void Continue()
        {
            Login login = new Login();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(login);
        }

        private void Skip()
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
