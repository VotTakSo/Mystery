using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Demoralization:Spell
    {
        public Demoralization()
        {
            Element = "death";
            img = "pack://application:,,,/Resources/Creatures/5.Death/Demoralization.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                mrTorry.death -= 3;

                mass[mrTorry.target].buffAtack = mass[mrTorry.target].Attack;
                mass[mrTorry.target].Attack = mass[mrTorry.target].Attack / 2;
                mass[mrTorry.target].hodPas = 5;


            }
            else
            {
                enemy.death -= 3;

                mass[enemy.target].buffAtack = mass[enemy.target].Attack;
                mass[enemy.target].Attack = mass[enemy.target].Attack/2;
                mass[enemy.target].hodPas = 5;
            }
        }
    }
}
