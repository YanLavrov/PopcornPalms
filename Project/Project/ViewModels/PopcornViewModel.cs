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
    internal class PopcornViewModel : ViewModelBase
    {
        public RelayCommand SkipCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public PopcornViewModel()
        {
            SkipCommand = new RelayCommand(Skip);
            CloseCommand = new RelayCommand(Close);
        }

        private void Skip()
        {
            Payment payment = new Payment();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(payment);
        }
        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
