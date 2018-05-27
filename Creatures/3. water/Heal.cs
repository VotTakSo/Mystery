using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Heal:Spell
    {
        public Heal()
        {
            Element = "water";
            manaCast = 6;
            img = "pack://application:,,,/Resources/Creatures/3.Water/Heal.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int heal = 0;
            if (mrTorry.first)
            {
                mrTorry.HP += mrTorry.water;
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        heal = mrTorry.water;
                        if (heal + mass[i].Hp > mass[i].maxHp)
                            mass[i].Hp = mass[i].maxHp;
                        else
                            mass[i].Hp = mass[i].Hp +heal;
                    }
                }
                mrTorry.water=0;

            }
            else
            {
                enemy.HP += enemy.water;
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        heal = enemy.water;
                        if (heal + mass[i].Hp > mass[i].maxHp)
                            mass[i].Hp = mass[i].maxHp;
                        else
                            mass[i].Hp = mass[i].Hp + heal;
                    }
                }
                enemy.water = 0;
            }

        }

    }
}
