using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Ghost:Creature
    {
        public Ghost(int poleNumbers, int poleNumbersVS)
        {
            Attack = 3;
            maxHp = 20;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Ghost";
            Element = "death";

            manaCost = 4;
            img = "pack://application:,,,/Resources/Creatures/5.Death/ghost.png";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second) { }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        { }

        public override void ActionEveryStep()
        {
            master.death++;
        }

    }
}
