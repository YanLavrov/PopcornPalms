using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Questionss
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string Question { get; set; }
        public string StatusQuestion { get; set; }

        public Questionss(string question)
        {
           Question = question;
           StatusQuestion = "Not processed";
        }
    }
}
