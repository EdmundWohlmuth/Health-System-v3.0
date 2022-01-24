using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class GameCharacters
    {
        public int maxHealth;
        public int health;

        public int maxShield;
        public int shield;

        public const int maxLives = 3;
        public int lives;

        public void TakeDamge(int damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                health += shield;
                shield = 0;
            }
        }

        public void Heal(int healing)
        {
            health += healing;
            if (health > 100)
            {
                health = maxHealth;
            }
        }

        public void RegenerateShield(int shieldGen)
        {
            shield += shieldGen;
            if (shield > maxShield)
            {
                shield = maxShield;
            }
        }

    }
}
