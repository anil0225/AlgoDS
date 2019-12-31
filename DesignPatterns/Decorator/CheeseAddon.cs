using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CheeseAddon:IPizza
    {
        IPizza pizza;
        public CheeseAddon(IPizza basePizza) {
            pizza = basePizza;
        }

        public int GetCost()
        {
            return 2 + pizza.GetCost();
        }

        public string GetDescription()
        {
            return pizza.GetDescription() + "-Cheese";
        }
    }
}
