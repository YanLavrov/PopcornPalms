using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Project.Models
{
    public class TemporaryCard
    {
        public static string Id;
        public static string CardNumber;
        public static string ValidUntil;
        public static string CVV;
        public static string CardHolder;

        public TemporaryCard() { }

        public TemporaryCard(Card card)
        {
            CardNumber = card.CardNumber;
            ValidUntil = card.ValidUntil;
            CVV = card.CVV;
            CardHolder = card.CardHolder;
        }
    }
}
