﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Goblin : Creature
    {
        

        public Goblin(int poleNumbers, int poleNumbersVS)
        {
            Attack = 1;
            maxHp = 16;
            Hp = maxHp;
            armor = 0;

            attack = new UssualAttack();

            name = "Goblin";
            Element = "fire";
            manaCost = 1;
            img= "pack://application:,,,/Resources/Creatures/1.Fire/Goblin.jpg";

            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second)
        {
            //if (master == mrTorry)
            //{
            //    for (int i = 6; i < 11; i++)
            //    {
            //        if (mass[i] != null)
            //        {
            //            if(mass[i].armor<3)
            //            mass[i].Hp -= (2  - mass[i].armor);
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i < 6; i++)
            //    {
            //        if (mass[i] != null)
            //        {
            //            if (mass[i].armor < 3)
            //                mass[i].Hp -= (2 - mass[i].armor);
            //        }
            //    }
            //}
        }

        public override void ActionAtBegin(Creature[] mass, Player first, Player second) {
            first.wind++;
        }

        public override void ActionEveryStep() { }

    }
}
