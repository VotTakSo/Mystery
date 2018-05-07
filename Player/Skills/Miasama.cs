using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery.Player.Skills
{
    class Miasama:SkillInterface
    {
        public Creature[] skill(Creature[] creMass, Creature cre, Player enemy, int skillLvl)
        {
            if (cre.Element == "death")
            {
                if (cre.Hp*100/cre.maxHp >= 55)
                {
                    creMass[cre.poleNumber].Hp += skillLvl;
                    if (creMass[cre.poleNumberVS] != null)
                        creMass[cre.poleNumberVS].Hp -= skillLvl;
                    else
                        enemy.Hp -= skillLvl;
                }
            }
            return creMass;
        }
    }
}
