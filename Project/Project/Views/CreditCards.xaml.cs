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
    /// Interaction logic for CreditCards.xaml
    /// </summary>
    public partial class CreditCards : Page
    {
        DataAccess db;
        public CreditCards()
        {
            InitializeComponent();
            db = new DataAccess();
            OutCard();
        }

        public void OutCard()
        {
            Number_Card.Content = TemporaryCard.CardNumber;
            Valid_THRU.Content = TemporaryCard.ValidUntil;
            Cerd_Holder.Content = TemporaryCard.CardHolder;
            CVV.Content = TemporaryCard.CVV;
        }
    }
}
