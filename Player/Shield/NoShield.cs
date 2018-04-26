using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoShield:ShieldInterface
    {
        public int shield(Player first, string Element) { return 0; }
    }
}
