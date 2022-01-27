using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Program
    {       
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();
            Unit_Test unit_Test = new Unit_Test();

            // Run Error Check
            unit_Test.RunUnitTest();

            while (player.hasLives)
            {
                player.ShowHUD();
                player.TakeDamge(10);
                player.Heal(5);
                player.RegenerateShield(5);
                Console.ReadKey(true);
                Console.Clear();
                enemy.ShowStats();
                enemy.TakeDamge(30);
                enemy.Heal(5);
                Console.ReadKey(true);
                Console.Clear();
            }
            

            Console.ReadKey(true);

        }
    }
}
