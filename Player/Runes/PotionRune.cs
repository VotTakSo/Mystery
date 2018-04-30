using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class PotionRune:RuneInterface
    {
        public Player Rune(Player pl, string s)
        {
            pl.fire += 1;
            pl.wind += 1;
            pl.water += 1;
            pl.earth += 1;
            pl.death += 1;
            return pl;
        }
    }
}
