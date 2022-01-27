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
            Console.WriteLine("Takes " + damage + " Damage");
            if(damage < 0)
            {
                damage = 0;
                return;
            }
            if (damage == int.MaxValue || damage == int.MinValue)
            {
                return;
            }

            shield -= damage;
            if (shield < 0)
            {
                health += shield;
                shield = 0;

                if (health <= 0)
                {
                    lives--;
                    shield = maxShield;
                    health = maxHealth;                                     
                }
            }
        }

        public void Heal(int healing)
        {
            Console.WriteLine("Heals " + healing + " Health");
            if (healing < 0)
            {
                healing = 0;
                return;
            }
            if (healing == int.MaxValue || healing == int.MinValue)
            {
                return;
            }

            health += healing;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void RegenerateShield(int shieldGen)
        {
            Console.WriteLine("Regenerates " + shieldGen + " Shield");
            if (shieldGen < 0)
            {
                shieldGen = 0;
                return;
            }
            if (shieldGen == int.MaxValue || shieldGen == int.MinValue)
            {
                return;
            }

            shield += shieldGen;
            if (shield > maxShield)
            {
                shield = maxShield;
            }
        }

    }
}
