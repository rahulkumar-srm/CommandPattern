using System;

namespace CommandPattern
{
    internal class Light
    {
        public string Location {  get; set; }

        public Light(string location)
        {
            Location = location;
        }

        public void On()
        {
            Console.WriteLine(Location + " light is on");
        }

        public void Off()
        {
            Console.WriteLine(Location + " light is off");
        }
    }
}