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
    internal class PaymentViewModel : ViewModelBase
    {
        public RelayCommand BackCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public PaymentViewModel()
        {
            BackCommand = new RelayCommand(Back);
            CloseCommand = new RelayCommand(Close);
        }

        private void Back()
        {
            ChoosePlace choosePlace = new ChoosePlace();    
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(choosePlace);
        }
        private void Close()
        {
            MainWindow mainWindow = Project.App.Current.MainWindow as MainWindow;
            mainWindow.Close();
        }
    }
}
