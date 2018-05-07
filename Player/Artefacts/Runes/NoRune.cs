using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoRune:RuneInterface
    {
        public Player Rune(Player pl, string bootsMana) { return pl; }
    }
}
