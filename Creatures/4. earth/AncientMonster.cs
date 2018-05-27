using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class AncientMonster:Creature
    {
        public AncientMonster(int poleNumbers, int poleNumbersVS)
        {
            Attack = 7;
            maxHp = 36;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "AncientMonster";
            Element = "earth";

            img = "pack://application:,,,/Resources/Creatures/4.Earth/AncientMonster.jpg";
            manaCost = 10;
            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second)
        {

        }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        {
            int dmg = 0;
            if (first.name == "mrTorry")
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        dmg = 10 - mass[i].armor;
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
                        dmg = 10 - mass[i].armor;
                        if (dmg > 0)
                            mass[i].Hp = mass[i].Hp - dmg;
                       
                    }
                }
            }
        }

        public override void ActionEveryStep() { }

    }
}
