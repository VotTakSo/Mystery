using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class ElementRune:RuneInterface
    {
        public Player Rune(Player pl, string bootsMana)
        {
            switch (bootsMana)
            {
                case "fire":
                    {
                        pl.fire += 2;
                        break;
                    }
                case "wind":
                    {
                        pl.wind += 2;
                        break;
                    }
                case "water":
                    {
                        pl.water += 2;
                        break;
                    }
                case "earth":
                    {
                        pl.earth += 2;
                        break;
                    }
                case "death":
                    {
                        pl.death += 2;
                        break;
                    }
            }

            return pl;
        }
    }
}
