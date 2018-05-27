using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Kramola:Spell
    {
        public Kramola()
        {
            Element = "earth";
            manaCast = 10;
            img = "pack://application:,,,/Resources/Creatures/4.Earth/Kramola.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                mrTorry.earth -= manaCast;

                enemy.HP -= mass[mrTorry.target].Attack;

            }
            else
            {
                enemy.earth -= manaCast;

                mrTorry.HP -= mass[enemy.target].Attack;
            }
        }
    }
}
