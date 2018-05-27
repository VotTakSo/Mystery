using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Meteorite : Spell
    {
        public Meteorite()
        {
            Element = "fire";
            manaCast = 7;
            img = "pack://application:,,,/Resources/Creatures/1.Fire/Meteor.jpg";
        }
       public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int max_i=0;
            int maxHP = 0;
            int dmg = 0;
            if (mrTorry.first)
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].Hp>maxHP)
                        {
                            maxHP = mass[i].Hp;
                            max_i = i;
                        }
                    }
                }
                mass[max_i].Hp = mass[max_i].Hp - 10;
                mass[max_i].buffAtack = mass[max_i].Attack;
                mass[max_i].Attack = 0;
                mass[max_i].hodPas = 5;
                mrTorry.fire -= manaCast;
            }
            else
            {
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].Hp > maxHP)
                        {
                            maxHP = mass[i].Hp;
                            max_i = i;
                        }
                    }
                }
                dmg = 10 - mass[max_i].armor;
                if (dmg > 0)
                    mass[max_i].Hp = mass[max_i].Hp - dmg;
                mass[max_i].buffAtack = mass[max_i].Attack;
                mass[max_i].Attack = 0;
                mass[max_i].hodPas = 5;
                enemy.fire -= manaCast;
            }
        }
    }
}
