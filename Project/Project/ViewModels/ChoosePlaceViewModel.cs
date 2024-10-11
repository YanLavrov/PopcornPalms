using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Project.ViewModels
{
    internal class ChoosePlaceViewModel : ViewModelBase
    {
        public RelayCommand BackCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public ChoosePlaceViewModel()
        {
            BackCommand = new RelayCommand(Back);
            CloseCommand = new RelayCommand(Close);
        }

        private void Back()
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
