using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CombinationPizza : IPizza
    {
        public double Price { get; set; } = 21.99;
        public bool ToGo { get; set; } = true;

        public void GetDetails()
        {
            Console.WriteLine("Good choice! Our combination pizza is to die for!");
        }
    }
}
