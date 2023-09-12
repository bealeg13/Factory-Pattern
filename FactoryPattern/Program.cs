namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of pizza would you like to order?");

            string userInput = Console.ReadLine();

            IPizza pizza = PizzaFactory.GetPizza(userInput);
            
            pizza.GetDetails();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here's your order summary.");
            Console.WriteLine("___________________________");
            Console.WriteLine();
            
            Console.WriteLine($"Pizza price: ${pizza.Price}");
            Console.WriteLine($"Would you like that to go?: {pizza.ToGo}");
        }
    }
}
