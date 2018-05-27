using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class ChainLightning : Spell
    {
        public ChainLightning()
        {
            Element = "wind";
            manaCast = 8;
            img = "pack://application:,,,/Resources/Creatures/2.Wind/ChainLightning.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int dmg = 0;
            if (mrTorry.first)
            {
                enemy.HP -= (mrTorry.wind - 4);
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        
                        dmg = mrTorry.wind - 4 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                       

                    }
                }
                mrTorry.wind = 0;
            }
            else
            {
                mrTorry.HP -= (enemy.wind - 4);
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                       
                        dmg = enemy.wind - 4 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                       
                    }
                }
                enemy.wind = 0;
            }

        }
    }
}
