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
        internal int score;
        internal int lives;
        internal Slot[,] GameWorld = new Slot[28, 87];
        public IEntity[] entities;

        public void Update()
        {
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
