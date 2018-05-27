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

       
    }
}
