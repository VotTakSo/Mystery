using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class CloackOfVipers:CloackInterface
    {
        public Creature Cloack(Creature cre, Player pl)
        {
            if (cre != null)
              
                {
                    cre.buffAtack = cre.Attack;
                    cre.Attack = 0;
                    cre.hodPas = 3;
                }
            return cre;
        }

        public Creature ReturnAttack(Creature cre)
        {
            if (cre != null)
                if (cre.hodPas != 0)
                {
                    cre.hodPas--;
                    if (cre.hodPas == 0)
                    {
                        cre.Attack = cre.buffAtack;
                    }
                }
            return cre;
        }
    }
}
