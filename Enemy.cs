
namespace Space_Invaders
{// Struct cell, representa uma célula no Game of Life
    public struct Mob:IEntity
    {
        public bool Alive { get; private set; }

        // Coordenadas deste mob
        private readonly int xMob, yMob;
        


        // Referência ao mundo de simulação
        private readonly DoubleBuffer2D<IEntity> simWorld;

        // Construtor
        public Mob(
            bool alive, int xMob, int yMob, DoubleBuffer2D<IEntity> simWorld)
        {
            // Guardar dados passados no construtor
            Alive = alive;
            this.simWorld = simWorld;
            this.xMob = xMob;
            this.yMob = yMob;
            
        }
    }
    class Enemy
    {
        private const string ovini  = @"<O>";
        private const string large  = @"|L|";
        private const string medium = @"\M/";
        private const string small  = @"/S\";
        private const string bullet = @"!";


        public int tier;
        private bool alive = true;
        private string visual;
        private uint killPoints = 0;
        private readonly float speed;




        public Enemy(int tier)
        {
            this.tier = tier;
        }

        public void Shoot()
        {

        }

        public void Die()
        {
            alive = false;
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
