using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public interface SkillInterface
    {
        Creature[] skill(Creature[] creMass, Creature cre, Player pl, int skillLvl);
    }
}
