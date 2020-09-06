using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];


            for(int i = 0; i < 7; i++)
            {
                onCommands[i] = new dumbCommand();
                offCommands[i] = new dumbCommand();
            }
        }

        public void setCommand(int slot,ICommand onCommand,ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n---Remote Control---\n");
            for(int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + onCommands[i].GetType().Name + "   " + offCommands[i].GetType().Name + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
