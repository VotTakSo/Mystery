using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Goblin : Creature
    {
        

        public Goblin(int poleNumbers, int poleNumbersVS)
        {
            Attack = 8;
            maxHp = 20;
            Hp = 20;
            armor = 0;

            attack = new UssualAttack();

            name = "Goblin";
            Element = "Fire";

            img= "pack://application:,,,/Resources/Creatures/1.Fire/Goblin.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player mrTorry, Player enemy)
        {
            if (master == mrTorry)
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        if(mass[i].armor<3)
                        mass[i].Hp -= (2  - mass[i].armor);
                    }
                }
            }
            else
            {
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].armor < 3)
                            mass[i].Hp -= (2 - mass[i].armor);
                    }
                }
            }
        }

       
    }
}
