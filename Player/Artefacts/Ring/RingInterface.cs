using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public interface RingInterface
    {
        Creature[] Ring(Creature[] cre, int min, int max);
    }
}
