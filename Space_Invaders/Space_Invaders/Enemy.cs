
namespace Space_Invaders
{
    public class Enemy: IEntity
    {
        //classe que implementa os inimigos do jogo
        public uint tier;
        public uint SlotNumber { get; set; }
        public uint SCoorX     { get; set; }
        public uint SCoory     { get; set; }
        
        private uint killPoints = 0;
        private readonly float speed;
        

        // Construtor
        public Enemy(uint tier)
        {
            this.tier = tier;
        }

        public void Shoot() { }

        public void Die() { }
        

        //m�too para selecionar cada inimigo pelo seu n�vel
        private void SelectByTier(int tier)
        {
            switch (tier)
            {
                case 1: //grandes, menos pontos(f�ceis de acertar)
                    SlotNumber = 3;
                    killPoints = 10;
                    break;

                case 2: //m�dios, pontos normais
                    SlotNumber = 2;
                    killPoints = 20;
                    break;

                case 3://pequenos, mais pontos(dif�ceis de acertar)
                    SlotNumber = 1;
                    killPoints = 30;
                    break;

                case 4://ovni, muito mais pontos(dif�ceis de acertar,poucas chances de aparecer)

                    SlotNumber = 1;  
                    killPoints = 100;
                    break;

                default:
                    break;
            }
        }
    }
}