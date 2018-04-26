using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoWeapon:Weapon
    {
        public Creature[] Weapon(Creature[] cre, int mana, int min, int max) { return cre; }
    }
}
