using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class OrksRing:RingInterface
    {
        public Creature[] Ring(Creature[] cre, int min, int max)
        {
            int dmg = 0, i_min = 0;
            int buff;
            buff = 100;
            for (int i = min; i < max; i++)
            {

                if (cre[i] != null)
                {
                    if (buff > cre[i].Hp)
                    {
                        buff = cre[i].Hp;
                        i_min = i;
                    }
                    dmg++;
                }
            }
            cre[i_min].Hp -= dmg;
            return cre;
        }
    }
}
