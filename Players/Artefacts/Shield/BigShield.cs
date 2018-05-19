using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class BigShield:ShieldInterface
    {
        public int shield(Player first, string Element)
        {
            int Armor = 0;
            if (first.shieldElements == Element)
                Armor = 2;
            return Armor;
        }
    }
}
