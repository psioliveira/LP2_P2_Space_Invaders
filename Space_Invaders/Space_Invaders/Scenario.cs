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
        internal string[,] enemies;

        public IEntity[,] entities;

        public void Update()
        {
            Console.Clear();
            Draw_Hud();
        }


        public void StartScenario()
        {
            score = 0;
            lives = 3;
            for (int i = 0; i < entities.GetLength(1); i++)
            {

                for (int j = 0; j < entities.GetLength(2); j++)
                {
                    if (entities[i, j] is Enemy)
                    {
                        GetEnemie((entities[i, j] as Enemy).GetShip());

                    }
                }
            }
        }


        public void Draw_Hud()
        {
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.SetCursorPosition(2, 2);
            Console.Write("Score " + score);

            Console.SetCursorPosition(2, 32);
            Console.Write("Hi-Score " + hiScore);


            Console.SetCursorPosition(2, 68);
            Console.Write("Lives " + lives);

            Console.SetCursorPosition(0, 29);
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.SetCursorPosition(0, 30);
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
        }

        private void GetEnemie(string visual)
        {
            for (int i = 0; i < enemies.GetLength(1); i++)
            {
                for (int j = 0; j < enemies.GetLength(2); j++)
                {
                    if (enemies[i, j].Length <= 0)
                    {
                        enemies[i, j] = visual;
                    }

                }
            }
        }
    }
}
