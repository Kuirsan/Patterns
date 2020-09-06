using CommandPattern;
using System;

namespace CommandPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);

            remote.setCommand(lightOnCommand);
            remote.ButtonWasPressed();
        }
    }
}
