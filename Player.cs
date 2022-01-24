using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player
    {
        Enemy enemy = new Enemy();

        public int maxHealth;
        public int health;

        public const int maxShield = 100;
        public int shield;

        public const int maxLives = 3;
        public int lives;

        public int damage;

        public int EXP;
        public int Lvl;

        public bool hasLives;

        public Player()
        {
            maxHealth = 100;
            health = 100;

            shield = 100;

            lives = 3;

            EXP = 0;
            Lvl = 0;
        }

        public void TakeDamge()
        {
            Console.WriteLine("Player Takes " + enemy.damage + " Damage!");

            shield = enemy.damage - shield;
        }

        public void Heal()
        {

        }

        public void RegenerateShield()
        {

        }

        public void ShowHUD()
        {
            Console.WriteLine("============");
            Console.WriteLine("Health: " + health + "/" + maxHealth);
            Console.WriteLine("Shield: " + shield + "/" + maxShield);
            Console.WriteLine("Lives: " + lives + "/" + maxLives);
            Console.WriteLine("============");
        }

        // extra mile

        public void LevelUp()
        {

        }

    }
}
