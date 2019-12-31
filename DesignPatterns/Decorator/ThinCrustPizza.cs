using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ThinCrustPizza : IPizza
    {
        public int GetCost()
        {
            return 2;
        }

        public string GetDescription()
        {
            return "ThinCrust Base";
        }
    }
}
