using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class AutoDriveCarStragey : ITransportStrategy
    {
        public string GetTransport()
        {
            return "This is a self driving car";
        }
    }
}
