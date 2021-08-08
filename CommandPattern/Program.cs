using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomlight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomlightOnCommand = new LightOnCommand(livingRoomlight);
            LightOnCommand KitchenlightOnCommand = new LightOnCommand(kitchenLight);
            StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);

            LightOffCommand livingRoomlightOffCommand = new LightOffCommand(livingRoomlight);
            LightOffCommand KitchenlightOffCommand = new LightOffCommand(kitchenLight);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomlightOnCommand, livingRoomlightOffCommand);
            remoteControl.SetCommand(1, KitchenlightOnCommand, KitchenlightOffCommand);
            remoteControl.SetCommand(2, stereoOnWithCDCommand, stereoOffCommand);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.UndoButtonWasPressed();
            remoteControl.OnButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);

            Console.WriteLine();

            remoteControl.OffButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(2);

            Console.ReadKey();
        }
    }
}
