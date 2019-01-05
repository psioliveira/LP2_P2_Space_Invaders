
namespace Space_Invaders
{
    class Enemy: IEntity
    {
        //classe que implementa os enemies do jogo

        private const string ovini  = @"<O>";
        private const string large  = @"|L|";
        private const string medium = @"\M/";
        private const string small  = @"/S\";
        private const string bullet = @"!";


        public int tier;

        // Coordenadas deste mob
        private readonly int xMob, yMob;
        public bool Alive { get; set; }
        private string visual;
        private uint killPoints = 0;
        private readonly float speed;

        //Referencia ao mundo
        private readonly DoubleBuffer2D<IEntity> simSpace;

        // Construtor
        public Enemy(
            bool alive, int xMob, int yMob,
            int tier, DoubleBuffer2D<IEntity> simSpace)
        {
            // Guardar dados passados no construtor
            Alive = alive;
            this.simSpace = simSpace;
            this.xMob = xMob;
            this.yMob = yMob;
            this.tier = tier;
        }
        

        public void Shoot()
        {

        }

        public void Die()
        {
            Alive = false;
        }

        public string GetShip()
        {
            return visual;
        }

        private void SelectByTier(int tier)
        {
            switch (tier)
            {
                case 1:
                    visual = small;
                    killPoints = 10;
                    break;

                case 2:
                    visual = medium;
                    killPoints = 10;
                    break;

                case 3:
                    visual = large;
                    killPoints = 10;
                    break;

                case 4:

                    visual = ovini;
                    killPoints = 10;
                    break;

                default:
                    break;
            }
        }

       

    }
}