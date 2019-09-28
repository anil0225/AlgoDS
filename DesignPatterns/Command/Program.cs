using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            LightReceiver light = new LightReceiver();
            invoker.AddCommand(new RedColorCommand(light));
            invoker.AddCommand(new SwitchCommand(light));
            invoker.AddCommand(new SwitchCommand(light));
            invoker.AddCommand(new YellowColorCommand(light));
            invoker.AddCommand(new SwitchCommand(light));
            invoker.AddCommand(new SwitchCommand(light));

            invoker.ExecuteCommands();

            Console.ReadLine();
        }
    }
}
