using System;

namespace Space_Invaders
{
    /// <summary>
    /// classe responsavel por gerar uma instância do cenáriodo jogo
    /// </summary>
    class Scenario
    {
        /// <summary>
        /// score do jogador atual
        /// </summary>
        internal uint score;
        /// <summary>
        /// vidas do jogador atual
        /// </summary>
        internal uint lives;
        /// <summary>
        /// slots para os caracteres a serem apresentados no renderizador.
        /// </summary>
        internal Slot[,] gameWorld = new Slot[26, 87];
        /// <summary>
        /// Todas os objectos IEntity que existem no início do jogo.
        /// incluindo inimigos, jogador, barricadas, e projéteis(quando disparados).
        /// </summary>
        public IEntity[] entities = new IEntity[174];

        /// <summary>
        /// método update para atualizar variáveis e posição dos objectos no mundo.
        /// </summary>
        public void UpdateScenario()  { }

        /// <summary>
        /// Inicializa os objectos e os adiciona nas devidas posições iniciais. 
        /// </summary>
        public void StartScenario()
        {
            GenerateEntities();
            PlaceEntities();
            lives = (entities[0] as Player).lives;
        }

        /// <summary>
        /// Gera os objectos IEntity e os define pelo ID.
        /// </summary>
        private void GenerateEntities()
        {
            int enemies = 0; //1-59(1 = ovni)
            int neutrals = 0; //id 60-111
            bool player = false; //id 0
            for (uint i = 0; i < entities.Length; i++)
            {
                if (i == 0 && !player) //cria o player
                {//id = 0
                    player = true;
                    entities[i] = new Player();
                    continue;
                }


                if (enemies < 60)
                {
                    if (enemies == 0) //cria o ovni
                    {//id = 1
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

                if (neutrals < 112) //cria os blocos dos escudos
                { //id 64 ao 178
                    entities[i] = new Neutral(i);
                }


            }
        }

        /// <summary>
        /// Posicionar  os objectos no mundo de acordo com seu ID. 
        /// </summary>
        private void PlaceEntities()
        {
            int c = 0;
            int[] barrierPos = new int[] { 20, 5 };
            foreach (IEntity e in entities)
            {


                //player
                if (e.ID == 0)
                {
                    SetVisual(e);
                }

                //minions tier 1
                if (e.ID > 1 && e.ID < 14)
                {
                    e.SCoorY = 6;

                    for (int i = 0; i < e.SlotNumber; i++)
                    {
                        e.SCoorX = Convert.ToUInt32(c + i);
                        gameWorld[e.SCoorY, e.SCoorX].owner = e;
                    }
                    if (e.ID < 13) { c += 6; }
                    else { c = 0; }
                }


                //minions tier 2
                if (e.ID > 13 && e.ID < 39)
                {
                    if (e.ID < 26) { e.SCoorY = 8; }
                    else { e.SCoorY = 10; }

                    for (int i = 0; i < e.SlotNumber; i++)
                    {
                        e.SCoorX = Convert.ToUInt32(c + i);
                        gameWorld[e.SCoorY, e.SCoorX].owner = e;
                    }
                    if (e.ID > 37 || e.ID == 25) { c = 0; }
                    else { c += 6; }
                }


                //minions tier 3
                if (e.ID > 38 && e.ID < 64)
                {
                    if (e.ID < 51) { e.SCoorY = 12; }
                    else { e.SCoorY = 14; }

                    for (int i = 0; i < e.SlotNumber; i++)
                    {
                        e.SCoorX = Convert.ToUInt32(c + i);
                        gameWorld[e.SCoorY, e.SCoorX].owner = e;
                    }
                    if (e.ID > 62 || e.ID == 50) { c = 0; }
                    else { c += 6; }
                }

                //barreiras
                if (e.ID > 63 && e.ID <= 178)
                {
                    barrierPos = BuildBarrier(e, barrierPos);
                }
            }
        }

        /// <summary>
        /// define o visual dos objectos.
        /// </summary>
        private void SetVisual(IEntity entity)
        {
            for (int i = 0; i < entity.SlotNumber; i++)
            {
                gameWorld[entity.SCoorY, entity.SCoorX + i].owner = entity;
            }
        }

        /// <summary>
        /// Adiciona as barreiras nos seus respetivos lugares. 
        /// </summary>
        private int[] BuildBarrier(IEntity e, int[] lastPos)
        {
            int[] position = new int[] { 0, 0 };
            e.SCoorX = Convert.ToUInt32(lastPos[1]);
            e.SCoorY = Convert.ToUInt32(lastPos[0]);
            gameWorld[lastPos[0], lastPos[1]].owner = e;

            if (lastPos[0] == 20)
            {
                position[0] = lastPos[0];
                if (lastPos[1] == 10 || lastPos[1] == 34 || lastPos[1] == 56)
                { position[1] = lastPos[1] + 19; }

                if (lastPos[1] == 80)
                {
                    position[0]++;
                    position[1] = 4;
                }
            }


            if (lastPos[0] == 21)
            {
                position[0] = lastPos[0];
                if (lastPos[1] == 11 || lastPos[1] == 35 || lastPos[1] == 57)
                { position[1] = lastPos[1] + 17; }

                if (lastPos[1] == 81)
                {
                    position[0]++;
                    position[1] = 4;
                }
            }

            if (lastPos[0] == 22)
            {
                position[0] = lastPos[0];

                if (lastPos[1] == 6 || lastPos[1] == 30 ||
                    lastPos[1] == 52 || lastPos[1] == 76)
                { position[1] = lastPos[1] + 3; }

                if (lastPos[1] == 11 || lastPos[1] == 35 || lastPos[1] == 57)
                { position[1] = lastPos[1] + 17; }

                if (lastPos[1] == 81)
                {
                    position[0]++;
                    position[1] = 4;
                }
            }

            if (lastPos[0] == 23 || lastPos[0] == 24)
            {
                position[0] = lastPos[0];

                if (lastPos[1] == 5 || lastPos[1] == 29 ||
                    lastPos[1] == 51 || lastPos[1] == 75)
                { position[1] = lastPos[1] + 5; }

                if (lastPos[1] == 11 || lastPos[1] == 35 || lastPos[1] == 57)
                { position[1] = lastPos[1] + 17; }

                if (lastPos[1] == 81)
                {
                    position[0]++;
                    position[1] = 4;
                }
            }


            return position;
        }

        /// <summary>
        /// IA basica para movimentação dos inimigos.
        /// </summary>
        private void MovementEnemies()
        {
            foreach(IEntity e in entities)
            {
                if(e is Enemy)
                {
                    
                    if(!(e as Enemy).LeftMove)
                    {

                        (e as Enemy).MoveRight();

                    }
                }
            }
        }


    }
}

