using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class PizzaFactory
    {
        public static IPizza GetPizza(string choice)
        {
            switch (choice.ToLower())
            {
                case "pepperoni":
                    return new PepperoniPizza();
                case "combination":
                    return new CombinationPizza();
                case "cheese":
                    return new CheesePizza();
                default:
                        return new PepperoniPizza();
            }
        } 
    }
}
