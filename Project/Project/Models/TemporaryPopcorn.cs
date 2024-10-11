using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class TemporaryPopcorn
    {
        public static string Id;
        public static string PopcornVolume;
        public static string PopcornFlavor;
        public static string TotalPrice;

        public TemporaryPopcorn() { }

        public TemporaryPopcorn(Popcorns popcorn)
        {
            PopcornVolume = popcorn.PopcornVolume;
            PopcornFlavor = popcorn.PopcornFlavor;
            TotalPrice = popcorn.TotalPrice;
        }
    }
}
