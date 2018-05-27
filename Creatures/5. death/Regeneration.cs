using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Regeneration:Spell
    {
        public Regeneration()
        {
            Element = "death";
            img = "pack://application:,,,/Resources/Creatures/5.Death/Regeneration.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int count=0;
            if (mrTorry.first)
            {
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].Element == "death")
                        {
                            if (mass[i].Hp < mass[i].maxHp)
                            {
                                mass[i].Hp = mass[i].maxHp;
                                if (count == 0)
                                    mrTorry.death -= 6;
                                else
                                    mrTorry.death -= 3;
                            }
                        }
                    }
                    count++;
                    if (mrTorry.death < 3) i = 6;
                }
            }
            else
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].Element == "death")
                        {
                            if (mass[i].Hp < mass[i].maxHp)
                            {
                                mass[i].Hp = mass[i].maxHp;
                                if (count == 0)
                                    enemy.death -= 6;
                                else
                                    enemy.death -= 3;
                            }
                        }
                    }
                    count++;
                    if (enemy.death < 3) i = 6;
                }
            }

        }
    }
}
