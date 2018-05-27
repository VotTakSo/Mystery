using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class SeaSnake:Creature
    {
        public SeaSnake(int poleNumbers, int poleNumbersVS)
        {
            Attack = 3;
            maxHp = 20;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "SeaSnake";
            Element = "water";

            img = "pack://application:,,,/Resources/Creatures/3.Water/SeaSnake.jpg";

            manaCost = 4;

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second) { }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        { }

        public override void ActionEveryStep()
        {
            master.water++;
        }
    }
}
