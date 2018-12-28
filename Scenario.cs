using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Scenario
    {
        private readonly int hiScore;
        internal int score;
        internal int Lives;

        public Enemy[,] enemies;
        public Player[] player;
    }
}
