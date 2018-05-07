using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class EarthHeal:SkillInterface
    {
        public Creature[] skill(Creature[] creMass, Creature cre, Player pl, int skillLvl)
        {
            if (cre.Element == "earth")
            {
                creMass[cre.poleNumber].Hp += skillLvl;
            }
            return creMass;
        }
    }
}
