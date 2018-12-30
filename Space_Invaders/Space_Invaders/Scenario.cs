using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Scenario
    {
        //classe responsável pelo cenário do jogo
        private readonly int hiScore;
        internal int score;
        internal int lives;

        public IEntity[,] entities;

        public void Update()
        {
            Console.Clear();
            Hud();

        }



        public void Hud()
        {
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.SetCursorPosition(2,2);
            Console.Write("Score "+score);

            Console.SetCursorPosition(2, 32);
            Console.Write("Hi-Score " + hiScore);


            Console.SetCursorPosition(2, 68);
            Console.Write("Lives " + lives);

            Console.SetCursorPosition(0, 29);
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.SetCursorPosition(0, 30);
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
        }
    }
}
