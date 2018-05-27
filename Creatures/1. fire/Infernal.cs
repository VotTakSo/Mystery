using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Infernal:Creature
    {
        public Infernal(int poleNumbers, int poleNumbersVS)
        {
            Attack = 3;
            maxHp = 20;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Infernal";
            Element = "fire";

            manaCost = 4; 
            img = "pack://application:,,,/Resources/Creatures/1.Fire/Infernal.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second){ }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        { }

        public override void ActionEveryStep() {
            master.fire++;
        }

    }
}
