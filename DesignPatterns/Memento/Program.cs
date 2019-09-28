using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountOriginator originator = new AccountOriginator();
            originator.AccountHolder = "Anil";
            originator.CurrentState = new AccountState { CurrentAmmount = 5000, LastUpdated = new DateTime(2009, 01, 01) };
            CareTaker ct = new CareTaker();
            ct.Memento = originator.CreateMemento();


            Console.WriteLine("Application state Before change");
            Console.WriteLine(originator.AccountHolder);
            Console.WriteLine(originator.CurrentState.CurrentAmmount);
            Console.WriteLine(originator.CurrentState.LastUpdated);

            originator.AccountHolder = "Tester";
            originator.CurrentState.CurrentAmmount = 200;
            originator.CurrentState.LastUpdated = DateTime.Now;


            Console.WriteLine("Application state Post change");
            Console.WriteLine(originator.AccountHolder);
            Console.WriteLine(originator.CurrentState.CurrentAmmount);
            Console.WriteLine(originator.CurrentState.LastUpdated);

            originator.SetMemento(ct.Memento);
            Console.WriteLine("Application state Restored");
            Console.WriteLine(originator.AccountHolder);
            Console.WriteLine(originator.CurrentState.CurrentAmmount);
            Console.WriteLine(originator.CurrentState.LastUpdated);


            Console.ReadLine();



        }
    }
}
