using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class HealRune:RuneInterface
    {
        public Player Rune(Player pl, string s)
        {
            pl.HP += 15;
            return pl;
        }
    }
}
