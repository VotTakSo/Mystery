using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class FireAura:SkillInterface
    {
        public Creature[] skill(Creature[] creMass, Creature cre, Player player, int skillLvl)
        {
            if(cre.Element=="fire")
            {
                if(creMass[cre.poleNumberVS] != null)
                creMass[cre.poleNumberVS].Hp -= skillLvl;
            }
            return creMass;
        }
    }
}
