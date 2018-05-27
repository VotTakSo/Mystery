using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class IceMonster:Creature
    {
        public IceMonster(int poleNumbers, int poleNumbersVS)
        {
            Attack = 4;
            maxHp = 24;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "IceMonster";
            Element = "water";

            manaCost = 7;

            img = "pack://application:,,,/Resources/Creatures/3.Water/IceMonster.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second) { }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        { }

        public override void ActionEveryStep()
        {
            enemy.fire--;
        }
    }
}
