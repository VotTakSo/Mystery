using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public abstract class Spell
    {
        public int manaCast;
        public string Element;
        public string img;
        public abstract void Action(Creature[] mass, Player mrTorry, Player enemy);
    }
}
