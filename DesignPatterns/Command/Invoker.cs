using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        List<ICommand> _commands;

        public Invoker() {
            _commands = new List<Command.ICommand>();
        }

        public void AddCommand(ICommand command) {
            _commands.Add(command);
        }

        public void ExecuteCommands() {
            _commands.ForEach(x => x.Execute());
        }

    }
}
