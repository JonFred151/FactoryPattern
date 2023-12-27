using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class Math: IQuestion
    {
        public void Build()
        {
            Console.WriteLine("How many Apple do you get if Apples are $0.25 each, and you have $2.50?");
           
            Console.WriteLine("the anwser is 10");
        }
    }
}
