using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Quicksand:Spell
    {
        public Quicksand()
        {
            Element = "neitral";
            img = "pack://application:,,,/Resources/Creatures/6.Neitral/QuickSand.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int dmg = 0;
            if (mrTorry.first)
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                       if(mass[i].Attack>mass[i].Hp)
                        {
                            dmg = mass[i].Attack -= mass[i].armor;
                            mass[i].Hp -= dmg;
                        }
                    }
                }
                mrTorry.earth -= 6;
            }
            else
            {
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].Attack > mass[i].Hp)
                        {
                            dmg = mass[i].Attack -= mass[i].armor;
                            mass[i].Hp -= dmg;
                        }
                    }
                }
            }

        }
    }
}
