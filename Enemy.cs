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
        public Enemy()
        {
            maxHealth = 100;
            maxShield = 100;

            health = 100;
            shield = 100;
        }

        public void ShowStats()
        {
            Console.WriteLine("============");
            Console.WriteLine("Enemy Stats: ");
            Console.WriteLine("Health: " + health + "/" + maxHealth);
            Console.WriteLine("Shield: " + shield + "/" + maxShield);
            Console.WriteLine("============");
            Console.WriteLine("");
            Console.WriteLine("The Enemy...");
            Console.WriteLine("");
        }

        public void UnitTest()
        {
            // Typical Cases TakeDamage() / Healing / ShieldRegen
            // TakeDamage();
            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(50);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 50);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(150);
            Debug.Assert(health == 50);
            Debug.Assert(shield == 0);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(210);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 2);

            // Heal();
            health = 100;
            shield = 100;
            lives = 3;
            Heal(10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 50;
            shield = 100;
            lives = 3;
            Heal(10);
            Debug.Assert(health == 60);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 50;
            shield = 90;
            lives = 3;
            Heal(10);
            Debug.Assert(health == 60);
            Debug.Assert(shield == 90);
            Debug.Assert(lives == 3);

            health = 50;
            shield = 100;
            lives = 2;
            Heal(10);
            Debug.Assert(health == 60);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 2);

            // RegenerateShield()
            health = 100;
            shield = 100;
            lives = 3;
            RegenerateShield(10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 50;
            lives = 3;
            RegenerateShield(10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 60);
            Debug.Assert(lives == 3);

            health = 90;
            shield = 50;
            lives = 3;
            RegenerateShield(10);
            Debug.Assert(health == 90);
            Debug.Assert(shield == 60);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 50;
            lives = 2;
            RegenerateShield(10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 60);
            Debug.Assert(lives == 2);

            // Special Cases weird cases that could happen (1 damage, 1000 damage, 0 damage)
            // TakeDamage();
            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(10000000);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 2);

            health = 100;
            shield = 1;
            lives = 3;
            TakeDamge(1);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 0);
            Debug.Assert(lives == 3);
            TakeDamge(1);
            Debug.Assert(health == 99);
            Debug.Assert(shield == 0);
            Debug.Assert(lives == 3);

            health = 1;
            shield = 0;
            lives = 3;
            TakeDamge(1);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 2);

            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(0);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // Heal();
            health = 100;
            shield = 100;
            lives = 3;
            Heal(100000000);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            Heal(0);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // RegenerateShield();
            health = 100;
            shield = 100;
            lives = 3;
            RegenerateShield(100000000);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            RegenerateShield(0);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // Error Cases weird cases that cannot happen (- damage)
            // TakeDamage();
            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(-10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // Heal();
            health = 100;
            shield = 100;
            lives = 3;
            Heal(-10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // RegenerateShield();
            health = 100;
            shield = 100;
            lives = 3;
            RegenerateShield(-10);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // Min/max datatype values (int.maxvalue)
            // TakeDamage();
            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(int.MaxValue);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(int.MinValue);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // Heal();
            health = 100;
            shield = 100;
            lives = 3;
            TakeDamge(int.MaxValue);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            Heal(int.MinValue);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            // ShieldRegeneration();
            health = 100;
            shield = 100;
            lives = 3;
            RegenerateShield(int.MaxValue);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);

            health = 100;
            shield = 100;
            lives = 3;
            RegenerateShield(int.MinValue);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 3);           
        }
        
    }
}
