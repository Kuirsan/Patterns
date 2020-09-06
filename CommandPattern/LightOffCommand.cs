using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void execute()
        {
            _light.Off();
        }
    }
}
