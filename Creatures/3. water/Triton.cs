using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Triton:Creature
    {
        public Triton(int poleNumbers, int poleNumbersVS)
        {
            Attack = 1;
            maxHp = 16;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Triton";
            Element = "water";

            manaCost = 1;
            img = "pack://application:,,,/Resources/Creatures/3.Water/Triton.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second)
        {

        }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        {
            first.earth++;
        }

        public override void ActionEveryStep() { }
    }
}
