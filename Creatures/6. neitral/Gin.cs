using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Gin : Creature
    {
        public Gin(int poleNumbers, int poleNumbersVS)
        {
            Attack = 2;
            maxHp = 16;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Fairy";
            Element = "neitral";

            img = "pack://application:,,,/Resources/Creatures/6.Neitral/Gin.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second)
        {

        }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        {
            int min = 60;
            int i_min = 0;
            if (first.name == "mrTorry")
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
                    }
                }
                mass[i_min].Hp += 15;
            }
            else
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
                    }
                }
                mass[i_min].Hp += 15;
            }
        }

        public override void ActionEveryStep() { }

    }
}


