using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Unit_Test
    {

        Enemy enemy = new Enemy();
        Player player = new Player();

        public void RunUnitTest()
        {
            enemy.UnitTest();
            player.UnitTest();
            Console.Clear();
        }

    }
}
