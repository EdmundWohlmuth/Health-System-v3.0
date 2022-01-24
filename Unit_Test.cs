using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Health_System_v3._0
{
    class Unit_Test
    {

        Enemy enemy = new Enemy();
        Player player = new Player();

        public Unit_Test()
        {          

        }

        public void ErrorCheck()
        {
            Debug.Assert(enemy.damage > 0);
            Debug.Assert(player.damage > 0);

            Debug.Assert(player.maxHealth > 0);
            Debug.Assert(enemy.maxHealth > 0);

            Debug.Assert(enemy.maxShield > 0);
        }

    }
}
