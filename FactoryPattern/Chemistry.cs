using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class Chemistry: IQuestion
    {
        public void Build()
        {
            Console.WriteLine("What is this Chemical element? Au ");
            
            Console.WriteLine("This Anwser is gold.");
        }
    }
}
