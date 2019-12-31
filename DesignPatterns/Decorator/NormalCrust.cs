using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class NormalCrustPizza : IPizza
    {
        public int GetCost()
        {
            return 4;
        }

        public string GetDescription()
        {
            return "NormalCrust Base";
        }
    }
}
