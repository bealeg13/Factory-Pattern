using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PepperoniPizza : IPizza
    {
        public double Price { get; set; } = 17.99;
        public bool ToGo { get ; set ; } = true;

        public void GetDetails()
        {
            Console.WriteLine("Good choice! Our pepperoni pizza is the best in the world!");
        }
    }
}
