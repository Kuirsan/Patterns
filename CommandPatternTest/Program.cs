using CommandPattern;
using System;

namespace CommandPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl remote = new SimpleRemoteControl();
            //Light light = new Light();
            //LightOnCommand lightOnCommand = new LightOnCommand(light);

            //remote.setCommand(lightOnCommand);
            //remote.ButtonWasPressed();
            RemoteControl remoteControl = new RemoteControl();
            Light livingRoomLight = new Light();
            Light kitchenLight = new Light();
            CeilingFan ceilingFan = new CeilingFan("Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilinfFanOffCommand ceilinfFanOffCommand = new CeilinfFanOffCommand(ceilingFan);

            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.setCommand(2, ceilingFanHighCommand, ceilinfFanOffCommand);

            Console.WriteLine(remoteControl);

            remoteControl.onButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.undoButtonWasPushed();
            remoteControl.offButtonWasPushed(0);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.undoButtonWasPushed();
            remoteControl.undoButtonWasPushed();
        }
    }
}
