using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class ElementBoots:BootsInterface
    {
        public Player Boots(Player pl, string bootsMana)
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
                case "deth":
                    {
                        pl.death += 2;
                        break;
                    }
            }

            return pl;
        }
    }
}
