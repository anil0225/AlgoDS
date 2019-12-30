using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ManualDriveStrategy : ITransportStrategy
    {
        public string GetTransport()
        {
            return "This Car is a basic Model Manual Drive model";
        }
    }
}
