using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Damnation:Spell
    {
        public Damnation()
        {
            Element = "death";
            img = "pack://application:,,,/Resources/Creatures/5.Death/Damnation.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                enemy.fire -= 1;
                enemy.wind -= 1;
                enemy.earth -= 1;
                enemy.death -= 1;
                enemy.water -= 1;
                mrTorry.death -= 3;
               
            }
            else
            {
                mrTorry.fire -= 1;
                mrTorry.wind -= 1;
                mrTorry.earth -= 1;
                mrTorry.death -= 1;
                mrTorry.water -= 1;
                enemy.death -= 3;
            }

        }
    }
}
