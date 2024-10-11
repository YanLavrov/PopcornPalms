using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for Description.xaml
    /// </summary>
    public partial class Description : Page
    {
        private bool isMediaOpened = false;
        private bool isFirstImage = true;

        public Description()
        {
            InitializeComponent();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;

            mediaElement.Source = new Uri("D:/Универ/4 курс/1 семестр/ТСПП (Котик)/PopcornPalms/Project/Project/Trailer/AQuietPlace_DayOne.mp4", UriKind.Absolute);
            Image.Source = new BitmapImage(new Uri("D:/Универ/4 курс/1 семестр/ТСПП (Котик)/PopcornPalms/Project/Project/Photos/PlayerPlay.png", UriKind.Absolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In development...", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            if (isFirstImage)
            {
                Image.Source = new BitmapImage(new Uri("D:/Универ/4 курс/1 семестр/ТСПП (Котик)/PopcornPalms/Project/Project/Photos/PlayerPause.png", UriKind.Absolute));
                mediaElement.Play();
            }
            else
            {
                Image.Source = new BitmapImage(new Uri("D:/Универ/4 курс/1 семестр/ТСПП (Котик)/PopcornPalms/Project/Project/Photos/PlayerPlay.png", UriKind.Absolute));

                mediaElement.Pause();
            }
            isFirstImage = !isFirstImage;
        }
    }
}
