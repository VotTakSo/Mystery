using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Gargoyle:Creature
    {
        
        public Gargoyle(int poleNumbers, int poleNumbersVS)
        {
            Attack = 2;
            maxHp = 19;
            Hp = maxHp;
            armor = 0;
            
            attack = new UssualAttack();

            name = "Gargoyle";
            Element = "wind";

            img = "pack://application:,,,/Resources/Creatures/2.Wind/Gorgule.jpg";
            manaCost = 2;
            poleNumber = poleNumbers;
            poleNumberVS = poleNumbersVS;
        }

        public override void ActionAfterDeath(Creature[] mass, Player first, Player second)
        {
            if (first.name == "mrTorry")
            {
                first.armor--;
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].name != "Gargoyle") mass[i].armor--;
                    }
                }
            }
            else
            {
                second.armor--;
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].name != "Gargoyle") mass[i].armor--;
                    }
                }
            }
        }
        
        //увеличивать buffArmor в game  при вызове 
        public override void ActionAtBegin(Creature[] mass, Player first, Player second)
        {
            if (first.name == "mrTorry")
            {
                first.armor++;
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        if(mass[i].name!= "Gargoyle")
                        mass[i].armor++;
                    }
                }
            }
            else
            {
                second.armor++;
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        if (mass[i].name != "Gargoyle")
                            mass[i].armor++;
                    }
                }
            }
        }

        public override void ActionEveryStep() { }

    }
}
