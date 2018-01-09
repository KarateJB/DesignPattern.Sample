using System.Collections.Generic;
using System.Linq;

namespace DP.Domain.Samples.Command
{
    public class Invoker
    {
        private IList<Command> _commands = null;

        public Invoker()
        {
            this._commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            this._commands.Add(command);
        }

        public void CancelCommand(Command command)
        {
            this._commands.Remove(command);
        }

        public void Invoke()
        {
            foreach(var cmd in this._commands)
            {
                cmd.Execute();
            }
        }
    }
}