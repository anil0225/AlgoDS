using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SentenceHandler : Handler
    {

        public override void HandleRequest(string input)
        {
            Console.WriteLine("Splitting Sentences to words");
            if (input.Contains(" ")) 
            {
                var sentences = input.Split(' ');
                foreach (var word in sentences)
                {
                    Console.WriteLine(word);
                    //base.HandleRequest(word);
                }
            }
            //else{

            //    base.HandleRequest(input);
            //}
            base.HandleRequest(input);

        }
    }
}
