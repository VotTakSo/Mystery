using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Splinter:Weapon
    {
        public Creature[] Weapon(Creature[] cre, int mana, int min, int max)
        {
            if (mana < 80)
            {
                for (int i = min; i < max; i++)
                {
                    if (cre[i] != null && cre[cre[i].poleNumberVS] != null)



                        cre[cre[i].poleNumberVS].Hp -= 2;
                }
            }

            return cre;
        }
    }
}
