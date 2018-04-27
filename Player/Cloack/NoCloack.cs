using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoCloack:CloackInterface
    {
        public Creature Cloack(Creature cre, Player pl) { return cre; }
        public Creature ReturnAttack(Creature cre) { return cre; }
    }
}
