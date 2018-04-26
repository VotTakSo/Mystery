using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    
    public class Artefact
    {
        Random rand = new Random();

        

        public Creature[] DamageBow ( Creature[] cre, int mana, int min, int max)
        {
          
                
                int randomNumber = 0;
              
                while (cre[randomNumber] == null)
                {
                    randomNumber = rand.Next(min, max);

                }
                if (mana < 6)
                {
                    int dmg = rand.Next(3, 6);
                    cre[randomNumber].Hp -= dmg;
                }
            
            return cre;
        }

        public Creature[] Damage(Creature[] cre, int mana, int min, int max)
        {
            if (mana < 80)
            {
                for (int i = min; i < max; i++)
                {
                    if (cre[i] != null && cre[cre[i].poleNumberVS] != null)



                        cre[cre[i].poleNumberVS].Hp -= 2;
                }
            }

            return cre;
        }

        public Player Boots(Player pl, string bootsMana)
        {
            switch (bootsMana)
            {
                case "fire":
                    {
                        pl.fire += 2;
                        break;
                    }
                case "wind":
                    {
                        pl.wind += 2;
                        break;
                    }
                case "water":
                    {
                        pl.water += 2;
                        break;
                    }
                case "earth":
                    {
                        pl.earth += 2;
                        break;
                    }
                case "deth":
                    {
                        pl.death += 2;
                        break;
                    }
            }
            return pl;
        }

        public Player Amulet(Player pl)
        {
            pl.HP++;
            return pl;
        }

        public Creature CloackOfVipers(Creature cre, Player pl)
        {
            if(cre!=null)
            if(pl.cloack)
            {
                cre.buffAtack = cre.Attack;
                cre.Attack = 0;
                cre.hodPas = 3;
            }
            return cre;
        }
        public Creature CloackOfVipersReturnAttack(Creature cre)
        {
            if(cre!=null)
            if (cre.hodPas != 0)
            {
                cre.hodPas--;
                if (cre.hodPas == 0)
                {
                    cre.Attack = cre.buffAtack;
                }
            }
            return cre;
        }

        public Creature[] Ring(Creature[] cre, int min, int max)
        {
            int dmg = 0, i_min=0;
            int buff;
            buff = 100;
            for (int i = min; i < max; i++)
            {

                if (cre[i] != null)
                {
                    if (buff > cre[i].Hp)
                    {
                        buff = cre[i].Hp;
                        i_min = i;
                    }
                    dmg++;
                }
            }
            cre[i_min].Hp -= dmg;
            return cre;
        }

        public int shieldOfOrks(Player first, Player second)
        {
            int Armor = 0;
            if (first.first)
            {
                if (first.shieldBuff == 1) Armor = 1;
            }
            else if (second.shieldBuff == 1) Armor = 1;
            return Armor;
        }

        public int shield(Player first, Player second, string Element)
        {

            int Armor = 0;
            if (first.first)
            {
                if (first.shieldElements == Element)
                Armor = 1;
            }
            else if (second.shieldElements == Element) Armor = 1;
            return Armor;
        }
    }
}
