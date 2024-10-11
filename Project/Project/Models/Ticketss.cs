using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Ticketss
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string NameofTicket { get; set; }
        public string Row { get; set; }
        public string Place { get; set; }
        public string Time { get; set; }
        public string NumberTicket { get; set; }
        public Ticketss(string nameofTicket, string row, string place, string time, string numberTicket)
        {
            NameofTicket = nameofTicket;
            Row = row;
            Place = place;
            Time = time;
            NumberTicket = numberTicket;
        }
    }
}
