using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player : GameCharacters
    {

        public int EXP;
        public int Lvl;

        public bool hasLives;

        public Player()
        {
            maxHealth = 100;
            health = 100;

            shield = 100;

            lives = 3;

            hasLives = true;

            EXP = 0;
            Lvl = 0;
        }

        // extra mile

        public void LevelUp()
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

    }
}
