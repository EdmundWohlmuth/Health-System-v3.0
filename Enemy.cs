using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy : GameCharacters
    {
        public Enemy()
        {
            maxHealth = 50;

            health = 50;
            shield = 25;
        }

        public void ShowStats()
        {

        }
        
    }
}
