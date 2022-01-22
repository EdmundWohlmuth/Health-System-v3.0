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
        public int health;

        public int maxShield;
        public int shield;

        public int maxLives;
        public int lives;

        public int damage;

        public int EXP;
        public int Lvl;

        public Player()
        {
            maxHealth = 100;
            health = 100;

            maxShield = 100;
            shield = 100;

            maxLives = 3;
            lives = 3;

            EXP = 0;
            Lvl = 0;
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

        // extra mile

        public void LevelUp()
        {

        }

    }
}
