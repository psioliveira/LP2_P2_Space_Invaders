namespace Space_Invaders
{
    /// <summary>
    /// classe responsável pelos slots do mapa
    /// </summary>
    class Slot
    {
        /// <summary>
        /// caractere que define a estética do que contém no slot
        /// </summary>
        internal char c = ' ';

        /// <summary>
        /// entidade que se encontra neste slot no momento
        /// </summary>
        internal IEntity owner;

        /// <summary>
        /// metodo de update para atualizar o objecto no qual 
        /// está a utilizar este slot no momento.
        /// </summary>
        internal void Update()
        {
            if (owner != null) { c = owner.Visual[owner.SCoorX]; }
            else { c = ' '; }

        }
        /// <summary>
        /// construtod para o objecto slot
        /// </summary>
        public Slot() { }



    }
}
