using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class UssualAttack:Attack
    {
        public Creature[] Damage(Creature[] mass, Creature cre, Player enemy)
        {
            int dmg = 0;
            if (mass[cre.poleNumber] != null)
                if (mass[cre.poleNumberVS] != null)
                {
                    dmg = cre.Attack - mass[cre.poleNumberVS].armor;
                    if (dmg > 0)
                        mass[cre.poleNumberVS].Hp -= dmg;
                }
                else
                {
                    enemy.HP -= cre.Attack;
                }

            return mass;
        }
    }
}
