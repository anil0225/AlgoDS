using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ParaHandler : Handler
    {

        public override void HandleRequest(string input)
        {
            Console.WriteLine("Splitting Para to Sentences");
            if (input.Contains("."))
            {
                var sentences = input.Split('.');
                foreach (var sentence in sentences)
                {
                    Console.WriteLine(sentence);
                   // base.HandleRequest(sentence);
                }
            }
            //else
            //{

            //    base.HandleRequest(input);
            //}

            base.HandleRequest(input);

        }
    }
}
