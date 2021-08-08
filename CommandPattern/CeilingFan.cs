using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CeilingFan
    {
        public FanSpeed Speed { get; set; }
        public string Location {  get; set; }

        public CeilingFan(string location)
        {
            this.Location = location;
            Speed = FanSpeed.Off;
        }

        public void High()
        {
            Speed = FanSpeed.High;
            Console.WriteLine(Location + " Ceiling Fan is set to high");
        }

        public void Medium()
        {
            Speed = FanSpeed.Medium;
            Console.WriteLine(Location + " Ceiling Fan is set to medium");
        }

        public void Low()
        {
            Speed = FanSpeed.Low;
            Console.WriteLine(Location + " Ceiling Fan is set to low");
        }

        public void Off()
        {
            Speed = FanSpeed.Off;
            Console.WriteLine(Location + " Ceiling Fan is set to off");
        }
    }

    public enum FanSpeed{
        High, Low, Medium, Off
    }
}
