using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Inferno:Spell
    {
        public Inferno()
        {
            Element = "fire";
            manaCast = 8;
            img = "pack://application:,,,/Resources/Creatures/1.Fire/Inferno.jpg";
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
                        dmg = mrTorry.fire/2+5 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                    }
                }
                mrTorry.fire = 0;
            }
            else
            {
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        dmg = enemy.fire / 2 + 5 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                    }
                }
                enemy.fire = 0;

            }
        }
    }
}
