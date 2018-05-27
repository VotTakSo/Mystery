using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Discharge : Spell
    {
        public Discharge()
        {
            Element = "wind";
            manaCast = 5;
            img = "pack://application:,,,/Resources/Creatures/2.Wind/Razriad.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            
            if (mrTorry.first)
            {
                mrTorry.wind -= manaCast;

                mass[mrTorry.target].Hp -= 10;

            }
            else
            {
                enemy.wind -= manaCast;

                mass[enemy.target].Hp -= 10;
            }
        }
    }
}
