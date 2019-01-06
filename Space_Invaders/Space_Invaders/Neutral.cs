
namespace Space_Invaders
{
    /// <summary>
    /// classe que implementa osobjectos neutros do jogo.
    /// </summary>
    class Neutral : IEntity
    {
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
        /// <summary>
        /// coordenadas do player no cenario.
        /// </summary>
        public uint SCoorY { get; set; }
        /// <summary>
        /// caracteres que definem a estetica do objecto
        /// </summary>
        public char[] Visual { get; set; }

        /// <summary>
        /// construtor para o objecto Neutral.
        /// </summary>
        public Neutral(uint id)
        {
            Visual[0] = '0';
            ID = id;
        }



    }
}
