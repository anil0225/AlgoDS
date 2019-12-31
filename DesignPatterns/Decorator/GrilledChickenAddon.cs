using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class GrilledChickenAddon:IPizza
    {
        IPizza pizza;
        public GrilledChickenAddon(IPizza basePizza) {
            pizza = basePizza;
        }

        public int GetCost()
        {
            return 5 + pizza.GetCost();
        }

        public string GetDescription()
        {
            return pizza.GetDescription() + "-Chicken";
        }

    }
}
