using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class QuestionFactory
    {

        public static IQuestion GetQuest(string Subject)
        {
            switch(Subject.ToLower())
            {
                case "math":
                    return new Math();
                case "history":
                    return new History();
                case "chemistry":
                    return new Chemistry();
                default:
                    return new History();
            }
        }

    }
}
