using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Storm : Spell
    {
        public Storm()
        {
            Element = "wind";
            manaCast = 1;
            img = "pack://application:,,,/Resources/Creatures/2.Wind/Storm.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            if (mrTorry.first)
            {
                enemy.HP = enemy.HP - 3;
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].Hp = mass[i].Hp - 3;
                    }
                }
                mrTorry.wind -= manaCast;
            }
            else
            {
                mrTorry.HP = mrTorry.HP - 3;
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].Hp = mass[i].Hp - 3;
                    }
                }
                enemy.wind -= manaCast;
            }
        }
    }
}
