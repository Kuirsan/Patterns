using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public SimpleRemoteControl() { }
        public void setCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.execute();
        }
    }
}
