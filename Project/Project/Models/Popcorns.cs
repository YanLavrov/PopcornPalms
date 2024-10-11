using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Popcorns
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string PopcornVolume { get; set; }
        public string PopcornFlavor { get; set; }
        public string TotalPrice { get; set; }

        public Popcorns(string popcornVolume, string popcornFlavor, string totalPrice)
        {
            PopcornVolume = popcornVolume;
            PopcornFlavor = popcornFlavor;
            TotalPrice = totalPrice;
        }
    }
}
