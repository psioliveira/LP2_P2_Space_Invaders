﻿using System;
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
        internal Slot[,] gameWorld = new Slot[28, 87];
        public IEntity[] entities = new IEntity[174];

        public void Update()
        {

        }

        public void StartScenario()
        {
            score = 0;
            lives = 3;
            GenerateEntities();
            PlaceEntities();
        }


        private void GenerateEntities()
        {
            int enemies = 0; //1-59(1 = ovni)
            int neutrals = 0; //id 60-111
            bool player = false; //id 0
            for (uint i = 0; i < entities.Length; i++)
            {
                if (i == 0 && !player)
                {
                    player = true;
                    entities[i] = new Player();
                    continue;
                }


                if (enemies < 60)
                {
                    if (enemies == 0) //cria o ovni
                    {
                        entities[i] = new Enemy(4, i);
                        enemies++;
                        continue;
                    }
                    if (enemies > 0 && enemies < 12) // cria os inimigos tier 3 
                    {//id do 2 ao 13
                        entities[i] = new Enemy(3, i);
                        enemies++;
                        continue;
                    }

                    if (enemies > 11 && enemies < 36) // cria os inimigos tier 2
                    { // id 14 ao 38 
                        entities[i] = new Enemy(2, i);
                        enemies++;
                        continue;
                    }

                    if (enemies > 37 && enemies < 60) // cria os inimigos tier 1
                    { //id 39 ao 63
                        entities[i] = new Enemy(1, i);
                        enemies++;
                        continue;
                    }
                }

                if (neutrals < 112) //cria os blocos dos esudos
                {
                    entities[i] = new Neutral(i);
                }


            }
        }

        private void PlaceEntities()
        {
            foreach (IEntity e in entities)
            {
                if (e.ID == 0)
                {
                    SetVisual(e);
                }

                if (e.ID)


            }
        }

        private void SetVisual(IEntity entity)
        {
            for (int i = 0; i < entity.SlotNumber; i++)
            {
                gameWorld[entity.SCoorY, entity.SCoorX + i].owner = entity;
            }
        }
    }
}

