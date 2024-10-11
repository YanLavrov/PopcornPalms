using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class TemporaryQuestion
    {
        public static string Id;
        public static string TempQuestion;

        public TemporaryQuestion() { }

        public TemporaryQuestion(Questionss questionss)
        {
            Id = questionss.Id;
            TempQuestion = questionss.Question;
            
        }
    }
}
