using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class DarkTouch:Spell
    {
        public DarkTouch()
        {
            Element = "wind";
            img = "pack://application:,,,/Resources/Creatures/5.Death/ghost.png";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                mrTorry.wind -= 5;

                mass[mrTorry.target].Hp -= 10;

            }
            else
            {
                enemy.wind -= 5;

                mass[enemy.target].Hp -= 10;
            }
        }
    }
}
