using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FlyCarStrategy : ITransportStrategy
    {
        public string GetTransport()
        {
            return "This is a future car that can FLY";
        }
    }
}
