using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class EarthWorms:Spell
    {
        public EarthWorms()
        {
            Element = "earth";
            manaCast = 4;
            img = "pack://application:,,,/Resources/Creatures/4.Earth/EarthWorms.jpg";
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

                        dmg = mass[i].Hp*45/100 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                       

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

                        dmg = mass[i].Hp * 45 / 100 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                    }
                }
                enemy.earth -= manaCast;
            }

        }
    }
}
