using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class ElementBuff:ElementsSkillInterface
    {
        public Player skill(Player player, int skillLvl, string Element)
        {
            switch (Element)
            {
                case "fire":
                    {
                        player.fire += skillLvl;
                        break;
                    }
                case "wind":
                    {
                        player.wind += skillLvl;
                        break;
                    }
                case "water":
                    {
                        player.water += skillLvl;
                        break;
                    }
                case "earth":
                    {
                        player.earth += skillLvl;
                        break;
                    }
                case "death":
                    {
                        player.death += skillLvl;
                        break;
                    }
            }
            return player;
        }
    }
}
