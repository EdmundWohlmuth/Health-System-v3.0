using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy
    {
        Player player = new Player();

        public int maxHealth;
        public int health;

        public int maxShield;
        public int shield;

        public int damage;

        public Enemy()
        {
            maxHealth = 50;
            maxShield = 25;

            health = 50;
            shield = 25;

            damage = 20;
        }

        public void TakeDamage()
        {

        }

        public void ShowHUD()
        {

        }
        
    }
}
