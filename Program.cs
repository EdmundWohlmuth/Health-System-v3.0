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
            unit_Test.ErrorCheck();

            player.ShowHUD();

            Console.ReadKey(true);

        }
    }
}
