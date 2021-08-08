using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CeilingFanHighCommand : ICommand
    {
        FanSpeed prevSpeed;
        CeilingFan ceilingFan;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.Speed;
            ceilingFan.High();
        }

        public void Undo()
        {
            if(prevSpeed == FanSpeed.High)
                ceilingFan.High();
            else if(prevSpeed == FanSpeed.Low)
                ceilingFan.Low();
            else if(prevSpeed == FanSpeed.Medium)
                ceilingFan.Medium();
            else if(prevSpeed == FanSpeed.Off)
                ceilingFan.Off();
        }
    }
}
