using Project.Models;
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

namespace Project.Views
{
    /// <summary>
    /// Interaction logic for AdminMain.xaml
    /// </summary>
    public partial class AdminMain : Page
    {
        public AdminMain()
        {
            InitializeComponent();
            LoadQuestions();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private async void LoadQuestions()
        {
            var dataAccess = new DataAccess();
            var questions = await dataAccess.getQuestion();

            var unansweredQuestions = questions.Where(q => q.StatusQuestion == "Not processed").ToList();

            QuestionsList.ItemsSource = unansweredQuestions;
        }

        public void UpdateQuestionsOnReturn()
        {
            LoadQuestions();
        }

        private void OnQuestionButtonClick(object sender, RoutedEventArgs e)
        {
            var selectedQuestion = (sender as Button)?.DataContext as Questionss;

            if (selectedQuestion != null)
            {
                AdminAnswerQuestion admin = new AdminAnswerQuestion(selectedQuestion, this);
                Frame mainFrame = Application.Current.MainWindow.Content as Frame;
                mainFrame.NavigationService.Navigate(admin);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have new messages", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            Bell.Source = new BitmapImage(new Uri("D:/Универ/4 курс/1 семестр/ТСПП (Котик)/PopcornPalms/Project/Project/Photos/Notification.png", UriKind.Absolute));
        }
    }
}
