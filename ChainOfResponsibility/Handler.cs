using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Handler
    {
        public Handler Next;
        public virtual void HandleRequest(string input)
        {
            if (Next != null)
                Next.HandleRequest(input);
        }

    }
}
