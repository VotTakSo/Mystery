using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class ElementalVortex:Spell
    {
        public ElementalVortex()
        {
            Element = "water";
            manaCast = 7;
            img = "pack://application:,,,/Resources/Creatures/3.Water/ElementVortex.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                mrTorry.fire += 2;
                mrTorry.wind += 2;
                mrTorry.earth += 2;
                mrTorry.death += 2;
                mrTorry.water -= manaCast;
            }
            else
            {
                enemy.fire += 2;
                enemy.wind += 2;
                enemy.earth += 2;
                enemy.death += 2;
                enemy.water -= manaCast;
            }

        }
    }
}
