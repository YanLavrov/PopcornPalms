using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Card
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string CardNumber { get; set; }
        public string ValidUntil { get; set; }
        public string CVV { get; set; }
        public string CardHolder { get; set; }

        public Card(string cardNumber, string validUntil, string cVV, string cardHolder)
        {
            CardNumber = cardNumber;
            ValidUntil = validUntil;
            CVV = cVV;
            CardHolder = cardHolder;
        }
    }
}
