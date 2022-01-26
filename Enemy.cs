using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Health_System_v3._0
{
    class Enemy : GameCharacters
    {
        public int damage;

        public Enemy()
        {
            maxHealth = 50;

            health = 50;
            shield = 25;
        }

        public void ShowStats()
        {
            Console.WriteLine("============");
            Console.WriteLine("Enemy Stats: ");
            Console.WriteLine("Health: " + health + "/" + maxHealth);
            Console.WriteLine("Shield: " + shield + "/" + maxShield);
            Console.WriteLine("============");
        }

        public void UnitTest()
        {

        }
        
    }
}
