using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Decomposition:Spell
    {
        public Decomposition()
        {
            Element = "death";
            img = "pack://application:,,,/Resources/Creatures/5.Death/Decomposition.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                mrTorry.death -= 5;
                enemy.HP -= 5;
                mass[mrTorry.target].Hp -= 5;

            }
            else
            {
                enemy.death -= 5;
                mrTorry.HP -= 5;
                mass[enemy.target].Hp -= 5;
            }
        }
    }
}
