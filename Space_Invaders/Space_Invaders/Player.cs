namespace Space_Invaders
{
    class Player : IEntity
    { /// <summary>
      /// clase que implementa o jogador.
      /// </summary>
      


        internal uint lives = 3;
        /// <summary>
        /// id do objecto como IEntity dentro do array de IEntity no cenário.
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// numero de slots que o objecto player ocupa no cenario do jogo.
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
        public char[] Visual { get; set; } = { 'd', 'T', 'b' };

        /// <summary>
        /// construtor para um objecto player.
        /// </summary>
        public Player()
        {
            SCoorY = 26;
            SCoorX = 0;
        }

        

        public void Shoot() { }

        /// <summary>
        /// methodo para descontar uma das vidas do jogador caso o mesmo morra
        /// </summary>
        public void Die()
        {
            if (lives > 0) { lives--; }
        }
        /// <summary>
        /// metodos de movimentação para o player
        /// </summary>
        public void MoveLeft()
        {
            if (SCoorX > 0) { SCoorX--; }
        }
        /// <summary>
        /// metodos de movimentação para o player
        /// </summary>
        public void MoveRight()
        {
            if (SCoorX < 83) { SCoorX++; }
        }
    }
}