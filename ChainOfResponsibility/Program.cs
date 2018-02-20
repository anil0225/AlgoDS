using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler para = new ParaHandler();
            Handler sentence = new SentenceHandler();
            Handler word = new WordHandler();

            para.Next = sentence;
            sentence.Next = word;

            para.HandleRequest("My name is Anil. I am testing the chain.");

            Console.ReadLine();
        }
    }
}
