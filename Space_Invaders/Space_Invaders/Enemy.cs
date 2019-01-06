
namespace Space_Invaders
{
    /// <summary>
    /// classe que implementa os inimigos do jogo.
    /// </summary>
    public class Enemy : IEntity
    {

        ///<summary> variável que define o 
        /// tipo de nave e suas propriedades.</summary>
        public uint tier;

        /// <summary>
        /// id do objecto como IEntity dentro do array de IEntity no cenário.
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// numero de slots que o objecto ocupa no cenario do jogo.
        /// </summary>
        public uint SlotNumber { get; set; }
        /// <summary>
        /// coordenadas do player no cenario.
        /// </summary>
        public uint SCoorX { get; set; }
        public uint SCoorY { get; set; }
        /// <summary>
        /// caracteres que definem a estética da nave
        /// </summary>
        public char[] Visual { get; set; } = { ' ', ' ', ' ' };
        /// <summary>
        /// pontuação pelo abate deste inimigo.
        /// </summary>
        private uint killPoints = 0;
        /// <summary>
        /// velocidade de deslocamento do inimigo.
        /// </summary>
        private readonly float speed;

        /// <summary>
        /// condição para inverter o movimento do inimigo.
        /// </summary>
        internal bool LeftMove = false;

        /// <summary>
        /// construtod do objecto Enemy
        /// </summary>
        public Enemy(uint tier, uint id)
        {
            this.tier = tier;
            ID = id;
        }


        public void Shoot() { }

        /// <summary>
        /// metodos de movimentação da nave
        /// </summary>
        public void MoveLeft()
        {
            if (SCoorX > 0) { SCoorX--; }

        }
        /// <summary>
        /// metodos de movimentação da nave
        /// </summary>
        public void MoveRight()
        {
            if (SCoorX > 0) { SCoorX--; }
        }
        /// <summary>
        /// metodos de movimentação da nave
        /// </summary>
        public void MoveDown()
        {
            if (SCoorY < 25) { SCoorY++; }

        }

        /// <summary>
        ///métoo para selecionar cada inimigo pelo seu nível
        /// </summary>
        private void SelectByTier(int tier)
        {
            switch (tier)
            {
                case 1: //grandes, menos pontos(fáceis de acertar)
                    SlotNumber = 3;
                    killPoints = 10;
                    Visual = new char[] { 'S', 'S', 'S' };
                    break;

                case 2: //médios, pontos normais
                    SlotNumber = 2;
                    killPoints = 20;
                    Visual = new char[] { 'M', 'M' };
                    break;

                case 3://pequenos, mais pontos(difíceis de acertar)
                    SlotNumber = 2;
                    killPoints = 30;
                    Visual = new char[] { 'G', 'G' };
                    break;

                case 4://ovni, muito mais pontos(difíceis de acertar,poucas chances de aparecer)


                    SlotNumber = 1;
                    killPoints = 100;
                    Visual = new char[] { 'O' };
                    break;

                default:
                    break;
            }
        }



    }
}