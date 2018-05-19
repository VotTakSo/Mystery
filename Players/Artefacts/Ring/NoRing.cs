using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoRing:RingInterface
    {
        public Creature[] Ring(Creature[] cre, int min, int max) { return cre; }
    }
}
