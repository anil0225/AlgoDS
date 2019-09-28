using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class WordHandler : Handler
    {

        public override void HandleRequest(string input)
        {
            Console.WriteLine("Splitting Words to Characters");
            if (!string.IsNullOrEmpty(input)) 
            {
                var word = input.ToCharArray();
                foreach (var character in word)
                {
                    Console.WriteLine(character);
                    //base.HandleRequest(character.ToString());
                }
            }
            //else{

            //    base.HandleRequest(input);
            //}
            base.HandleRequest(input);

        }
    }
}
