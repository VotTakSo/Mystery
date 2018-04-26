using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
     class TrippleAttack:Attack
    {
        public Creature[] Damage(Creature[] mass, Creature cre, Player enemy)
        {
            int min= cre.poleNumberVS - 1, max = cre.poleNumberVS + 1;
            if (cre.poleNumberVS == 6)
            {
                min = 6;
                max = 7;
            }
            if (cre.poleNumberVS == 10)
            {
                min = 9;
                max = 10;
            }
            if (cre.poleNumberVS == 1)
            {
                min = 1;
                max = 2;
            }
            if (cre.poleNumberVS == 5)
            {
                min = 4;
                max = 5;
            }
            for (int i = min; i <= max; i++)
            {

                
                if (mass[i] != null)
                {
                    mass[i].Hp -= (cre.Attack - mass[i].armor);
                }
                else
                {
                    enemy.HP -= cre.Attack;
                }
            }
            return mass;
        }
    }
}
