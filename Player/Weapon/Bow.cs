using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Bow:Weapon
    {
        Random rand = new Random();

        public Creature[] Weapon(Creature[] cre, int mana, int min, int max)
        {

           if(min==1)
            {
                min = 6;
                max = 11;
            }
           else
            {
                min = 1;
                max = 6;
            }
            int randomNumber = 0;

            while (cre[randomNumber] == null)
            {
                randomNumber = rand.Next(min, max);

            }
            if (mana < 9)
            {
                int dmg = rand.Next(3, 6);
                cre[randomNumber].Hp -= dmg;
            }

            return cre;
        }
    }
}
