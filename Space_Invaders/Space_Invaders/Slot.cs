using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Slot
    {

        internal char c = '.';
        internal IEntity owner;
        internal void Update()
        {
            c = owner.Visual;
        }
        public Slot() { }



    }
}
