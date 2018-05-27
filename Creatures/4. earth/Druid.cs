using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Druid:Creature
    {
        public Druid(int poleNumbers, int poleNumbersVS)
        {
            Attack = 2;
            maxHp = 16;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Druid";
            Element = "earth";

            manaCost = 3;
            img = "pack://application:,,,/Resources/Creatures/4.Earth/Druid.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second) { }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        { }

        public override void ActionEveryStep()
        {
            master.earth++;
        }
    }
}
