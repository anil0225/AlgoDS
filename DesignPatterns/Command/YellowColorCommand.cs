using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class YellowColorCommand : ICommand
    {
        LightReceiver _receiver;
        public YellowColorCommand(LightReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.SetColor("Yellow");
        }
    }
}
