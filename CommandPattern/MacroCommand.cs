using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }
        public void execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].execute();
            }
        }

        public void undo()
        {
            throw new NotImplementedException();
        }
    }
}
