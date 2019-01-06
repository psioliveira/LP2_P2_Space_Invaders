
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Player : IEntity
    { //clase que implementa o character para o jogador

        private int Pos;
        private uint lives = 3;
        public uint ID { get; set; }
        public uint SlotNumber { get; set; }
        public uint SCoorX { get; set; }
        public uint SCoorY { get; set; }
        public char[] Visual { get; set; } = { 'd', 'T', 'b' };

        public Player()
        {
            SCoorY = 26;
            SCoorX = 0;
        }

        

        public void Shoot() { }

        public void Die()
        {
            if (lives > 0) { lives--; }
        }
        public void MoveLeft()
        {
            if (Pos > 0) { Pos--; }
        }
        public void MoveRight()
        {
            if (Pos < 83) { Pos++; }
        }
    }
}