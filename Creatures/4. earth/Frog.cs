using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Frog:Spell
    {
        public Frog()
        {
            Element = "earth";
            manaCast = 6;
            img = "pack://application:,,,/Resources/Creatures/4.Earth/Frog.jpg";
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
                        mass[i].Attack = 0;
                        mass[i].hodPas = 3;
                    }
                }
                mrTorry.earth -= manaCast;
            }
            else
            {
                mrTorry.HP -= (enemy.wind - 4);
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].buffAtack = mass[i].Attack;
                        mass[i].Attack = 0;
                        mass[i].hodPas = 3;
                    }
                }
                enemy.earth -= manaCast;
            }

        }
    }
}
