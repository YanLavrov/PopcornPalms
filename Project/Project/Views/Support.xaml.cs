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

namespace Project
{
    /// <summary>
    /// Interaction logic for Support.xaml
    /// </summary>
    public partial class Support : Page
    {
        DataAccess db;
        public Support()
        {
            InitializeComponent();
            db = new DataAccess();

            //Time
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");
            Time.Content = formattedTime;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            Questionss questionss = new Questionss(textBox1.Text);
            TemporaryQuestion.Id = questionss.Id;
            TemporaryQuestion.TempQuestion = questionss.Question;
            await db.CreateQuestions(questionss);

            textBox1.Clear();
        }
    }
}
