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
    /// Interaction logic for AdminAnswerQuestion.xaml
    /// </summary>
    public partial class AdminAnswerQuestion : Page
    {
        private Questionss _question; 
        private DataAccess _dataAccess;
        private readonly AdminMain _adminMainPage;

        public AdminAnswerQuestion(Questionss question, AdminMain adminMainPage)
        {
            InitializeComponent();
            _question = question;
            _dataAccess = new DataAccess();
            _adminMainPage = adminMainPage;

            TextBlockQuestion.Text = _question.Question;

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await _dataAccess.UpdateQuestion(_question.Id, "Done");

            if(TextBoxAnswer.Text == "")
            {
                MessageBox.Show("Fill in the field", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Reply sent", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
                _adminMainPage.UpdateQuestionsOnReturn();
                NavigationService.GoBack();
            }


        }
    }
}
