using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoBoots:BootsInterface
    {
        public Player Boots(Player pl, string bootsMana) { return pl; }
    }
}
