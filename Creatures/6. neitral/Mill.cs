using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Mill:Spell
    {
        public Mill()
        {
            Element = "neitral";
            img = "pack://application:,,,/Resources/Creatures/6.Neitral/Mill.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int min = 60;
            int i_min = 0;
            int max = 0;
            int i_max = 0;
            if (mrTorry.first)
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].Hp < min)
                        {
                            min = mass[i].Hp;
                            i_min = i;
                        }
                        if (mass[i].Hp > max)
                        {
                            max = mass[i].Hp;
                            i_max = i;
                        }
                    }
                }
                Creature cre=mass[i_min];
                mass[i_min] = mass[i_max];
                mass[i_max] = cre;
            }
            else
            {
                enemy.wind -= 5;

                mass[enemy.target].Hp -= 10;
            }
        }
    }
}

