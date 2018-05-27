using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Weakness:Spell
    {
        public Weakness()
        {
            Element = "Weakness";
            img = "pack://application:,,,/Resources/Creatures/5.Death/Weakness.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].buffAtack = mass[i].Attack;
                        mass[i].Attack = mass[i].Attack/2;
                        mass[i].hodPas = 5;
                    }
                }
                mrTorry.death -= 5;
            }
            else
            {
                mrTorry.HP -= (enemy.wind - 4);
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].buffAtack = mass[i].Attack;
                        mass[i].Attack = mass[i].Attack / 2;
                        mass[i].hodPas = 5;
                    }
                }
                enemy.death -= 5;
            }

        }
    }
}
