using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Dendroid:Creature
    {
        public Dendroid(int poleNumbers, int poleNumbersVS)
        {
            Attack = 8;
            maxHp = 32;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Dendroid";
            Element = "earth";

            manaCost = 8;

            img = "pack://application:,,,/Resources/Creatures/4.Earth/Dendroid.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second) { }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        { }

        public override void ActionEveryStep()
        {
            enemy.death--;
        }
    }
}
