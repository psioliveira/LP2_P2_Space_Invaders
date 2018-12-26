using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    class Enemy
    {
        private const string large  = @"|L|";
        private const string medium = @"\M/";
        private const string small  = @"/S\";
        public int tier;
        private bool alive = true;
        private string visual;
        private uint killPoints = 0;

        public Enemy(int tier)
        {
            this.tier = tier;
        }



        public void Shoot() { }
        public void Die()
        {
            alive = false;
        }

        private void SelectByTier(int tier)
        {
            switch (tier)
            {
                case 1:
                    visual = "|Y|";
                    killPoints = 10;
                    break;

                case 2:
                    visual = medium;
                    killPoints = 10;
                    break;

                case 3:

                    break;

                case 4:

                    break;

                default:
                    break;
            }
        }

    }
}
