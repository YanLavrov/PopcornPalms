﻿using System;
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
    internal class OnboardingViewModel : ViewModelBase
    {
        public RelayCommand ContinueCommand { get; private set; }
        public RelayCommand SkipCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }

        public OnboardingViewModel()
        {
            ContinueCommand = new RelayCommand(Continue);
            SkipCommand = new RelayCommand(Skip);
            CloseCommand = new RelayCommand(Close);
        }

        private void Continue()
        {
            Onboarding2 onboarding2 = new Onboarding2();
            Frame mainFrame = Application.Current.MainWindow.Content as Frame;
            mainFrame.NavigationService.Navigate(onboarding2);
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
