using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class FireWall:Creature
    {
        public FireWall(int poleNumbers, int poleNumbersVS)
        {
            
            maxHp = 22;
            Hp = maxHp;
            

            attack = new UssualAttack();

            name = "FireWall";
            Element = "fire";

            img = "pack://application:,,,/Resources/Creatures/1.Fire/FireWall.jpg";
            manaCost = 2;
            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second){ }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        {
            if (first.name == "mrTorry")
            {
                second.HP = second.HP - 3;
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].Hp = mass[i].Hp - 3;
                    }
                }
            }
            else
            {
                first.HP = first.HP - 3;
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].Hp = mass[i].Hp - 3;
                    }
                }
            }
        }

        public override void ActionEveryStep() { }

    }
}
