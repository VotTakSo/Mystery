using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public interface Attack
    {
        Creature[] Damage(Creature[] mass, Creature cre, Player enemy);

    }
}
