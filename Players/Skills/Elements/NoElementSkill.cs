using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class NoElementSkill : ElementsSkillInterface

    {
        public Player skill(Player player, int skillLvl, string Element)
        {
            return player;
        }
    }
}
