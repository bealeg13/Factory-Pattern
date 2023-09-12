using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CheesePizza : IPizza
    {
        public double Price { get; set; } = 14.99;
        public bool ToGo { get ; set ; } = false;

        public void GetDetails()
        {
            Console.WriteLine("Good choice! Our cheese is imported from France.");
        }
    }
}
