﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RedColorCommand : ICommand
    {
        LightReceiver _receiver;
        public RedColorCommand(LightReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.SetColor("Red");
        }
    }
}
