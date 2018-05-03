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
            if (mass[cre.poleNumber] != null)
            if (mass[cre.poleNumberVS] != null)
            {
                mass[cre.poleNumberVS].Hp -= (cre.Attack - mass[cre.poleNumberVS].armor);
            }
            else
            {
                enemy.HP -= cre.Attack;
            }

            return mass;
        }
    }
}
