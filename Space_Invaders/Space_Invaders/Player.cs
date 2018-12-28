using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Player: IEntity
    {
        private uint lives = 3;
        private string visual = "dTb";
        private uint points = 0;

        public void Shoot() { }
        public void Die() { }



    }
}
