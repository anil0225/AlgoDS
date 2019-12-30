using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Car
    {
        ITransportStrategy transportStrategy;
        public Car(ITransportStrategy carTransportStrategy) {
            transportStrategy = carTransportStrategy;
        }

        public string DescribeCar() {
            return transportStrategy.GetTransport();
        }
    }
}
