using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Ghost:Creature
    {
        public Ghost(int poleNumbers, int poleNumbersVS, int Arm)
        {
            Attack = 5;
            Hp = 15;
            armor = 3+ Arm;

            name = "Ghost";
            Element = "Death";

            img = "pack://application:,,,/Resources/Ghost.png";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }
        public Ghost(int poleNumbers, int poleNumbersVS)
        {
            Attack = 5;
            Hp = 15;
            armor = 3;

            name = "Ghost";
            Element = "death";

            attack = new UssualAttack();

            img = "pack://application:,,,/Resources/Creatures/5.Death/Ghost.png";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player mrTorry, Player enemy)
        {
            if (master == mrTorry)
            {
                enemy.HP -= 10;
            }
            else
            {
                mrTorry.HP -= 10;
            }
        }

        //public override Creature[] Damage(Creature[] mass, Creature cre)
        //{
        //    //throw new NotImplementedException();
        //    mass[cre.poleNumberVS].Hp -= (cre.Attack - mass[cre.poleNumberVS].armor);
        //    return mass;
        //}
    }
}
