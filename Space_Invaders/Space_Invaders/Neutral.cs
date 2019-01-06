﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Neutral : IEntity
    {
        public uint ID { get; set; }
        public uint SlotNumber { get; set; }
        public uint SCoorX { get; set; }
        public uint SCoorY { get; set; }
        public char[] Visual { get; set; }


        public Neutral(uint id)
        {
            Visual[0] = '0';
            ID = id;
        }



    }
}
