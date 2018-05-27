using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class CallOfTheSirens:Spell
    {
        public CallOfTheSirens()
        {
            Element = "water";
            manaCast = 10;
            img = "pack://application:,,,/Resources/Creatures/3.Water/CallOfTheSirens.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int dmg = 0;
            if (mrTorry.first)
            {
                if (mrTorry.water < 12)
                {
                    for (int i = 1; i < 11; i++)
                    {
                        if (mass[i] != null)
                        {

                            dmg = 15 - mass[i].armor;
                            if (dmg > 0)
                                mass[i].Hp = mass[i].Hp - dmg;


                        }
                    }

                }
                else
                {
                    for (int i = 6; i < 11; i++)
                    {
                        if (mass[i] != null)
                        {

                            dmg = 15 - mass[i].armor;
                            if (dmg > 0)
                                mass[i].Hp = mass[i].Hp - dmg;


                        }

                    }
                }
                mrTorry.water -= 10;
            }
            else
            {
                
                    if (enemy.water < 12)
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (mass[i] != null)
                            {

                                dmg = 15 - mass[i].armor;
                                if (dmg > 0)
                                    mass[i].Hp = mass[i].Hp - dmg;


                            }
                        }

                    }
                    else
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            if (mass[i] != null)
                            {

                                dmg = 15 - mass[i].armor;
                                if (dmg > 0)
                                    mass[i].Hp = mass[i].Hp - dmg;


                            }

                        }
                    }
                    enemy.water -= 10;
                }

        }
    }
}
