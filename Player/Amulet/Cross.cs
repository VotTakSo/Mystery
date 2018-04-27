using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Cross:AmuletInterface
    {
        public Player Amulet(Player pl)
        {
            pl.HP++;
            return pl;
        }
    }
}
