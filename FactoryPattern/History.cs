using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class History: IQuestion
    {
        public void Build()
        {
            Console.WriteLine("Who wrote the declaration of independence?");
            
            Console.WriteLine("Thomas Jefferson");

        }
    }
}
