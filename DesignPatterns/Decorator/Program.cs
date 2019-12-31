using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPizza pizza = new ThinCrustPizza();
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());
            pizza = new CheeseAddon(pizza);
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());
            pizza = new GrilledChickenAddon(pizza);
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());

            pizza = new NormalCrustPizza();
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());
            pizza = new GrilledChickenAddon(pizza);
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());
            pizza = new CheeseAddon(pizza);
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine(pizza.GetDescription());
            


            Console.ReadLine();
        }
    }
}
