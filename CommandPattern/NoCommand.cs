﻿using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class NoCommand : ICommand
    {
        public void Execute()
        {
            
        }

        public void Undo()
        {
            
        }
    }
}
