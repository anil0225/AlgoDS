using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SwitchCommand : ICommand
    {
        LightReceiver _receiver;
        public SwitchCommand(LightReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.ToggleSwitch();
        }
    }
}
