using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Assasin:Creature
    {
        public Assasin(int poleNumbers, int poleNumbersVS)
        {
            Attack = 1;
            maxHp = 16;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Assasin";
            Element = "wind";

            img = "pack://application:,,,/Resources/Creatures/2.Wind/Assasin.jpg";
            manaCost = 1;
            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second)
        {
            
        }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        {
            first.death++;
        }

        public override void ActionEveryStep() { }
    }
}
