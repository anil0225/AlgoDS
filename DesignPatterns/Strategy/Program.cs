using System;

namespace Strategy
{
    class Program
    {

        /// <summary>
        /// Strategy Pattern suggests having Composition instead of Inheritance
        /// Should be used when algorithm of execution changes for the same object
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Car car = new Car(new FlyCarStrategy());
            Console.WriteLine(car.DescribeCar());
            car = new Car(new ManualDriveStrategy());
            Console.WriteLine(car.DescribeCar());
            car = new Car(new AutoDriveCarStragey());
            Console.WriteLine(car.DescribeCar());
            Console.ReadLine();
        }

    }
}
