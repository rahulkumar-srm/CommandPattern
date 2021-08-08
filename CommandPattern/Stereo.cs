using System;

namespace CommandPattern
{
    internal class Stereo
    {
        public string Location { get; set; }

        public Stereo(string location)
        {
            Location = location;
        }

        internal void ON()
        {
            Console.WriteLine(Location + " stereo is on");
        }

        internal void SetCD()
        {
            Console.WriteLine("CD is inserted");
        }

        internal void Off()
        {
            Console.WriteLine(Location + " steroe is off");
        }

        internal void SetVolume(int volume)
        {
            Console.WriteLine(Location + " Stereo Volumne is set to : " + volume);
        }
    }
}