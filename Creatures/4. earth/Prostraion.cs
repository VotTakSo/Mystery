using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Prostraion:Spell
    {
        public Prostraion()
        {
            Element = "earth";
            manaCast = 3;
            img = "pack://application:,,,/Resources/Creatures/4.Earth/Prostration.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                mrTorry.earth -= manaCast;

                mass[mrTorry.target].buffAtack = mass[mrTorry.target].Attack;
                mass[mrTorry.target].Attack = 0;
                mass[mrTorry.target].hodPas = 3;
              

            }
            else
            {
                enemy.earth -= manaCast;

                mass[enemy.target].buffAtack = mass[enemy.target].Attack;
                mass[enemy.target].Attack = 0;
                mass[enemy.target].hodPas = 3;
            }
        }
    }
}
