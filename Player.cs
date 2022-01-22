using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player
    {
        public int maxHealth;
        public int Health;

        public int maxShield;
        public int Shield;

        public int maxLives;
        public int Lives;

        public int damage;

        public Player()
        {
            maxHealth = 100;
            Health = 100;

            maxShield = 100;
            Shield = 100;

            maxLives = 3;
            Lives = 3;
        }

        public void TakeDamge()
        {

        }

        public void Heal()
        {

        }

        public void RegenerateShield()
        {

        }

        public void ShowHUD()
        {

        }

    }
}
