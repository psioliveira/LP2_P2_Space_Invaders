using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Enemy
    {
        public int tier;
        private bool alive = true;
        private string visual;
        private uint killPoints = 0;

        public Enemy(int tier)
        {
            this.tier = tier;
        }



        public void Shoot() { }
        public void Die()
        {
            alive = false;
        }



    }
}
