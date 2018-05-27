using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class Sabbath : Spell
    {

        public Sabbath()
        {
            Element = "wind";
            manaCast = 3;
            img = "pack://application:,,,/Resources/Creatures/2.Wind/Sabbath.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {

            if (mrTorry.first)
            {
                if (mass[mrTorry.target] != null)
                    if (mass[mass[mrTorry.target].poleNumberVS] != null)
                    {
                        mrTorry.wind -= manaCast;
                        //добавить поле: стоимость маны существам. возвращать столько маны

                        if (mass[mrTorry.target].hodPas > 0)
                            mass[mrTorry.target].Attack = mass[mrTorry.target].buffAtack;
                        mass[mrTorry.target].hodPas = 0;
                    }
            }
            else
            {
                if (mass[mass[enemy.target].poleNumberVS] != null)
                {
                    enemy.wind -= manaCast;

                    if (mass[enemy.target].hodPas > 0)
                        mass[enemy.target].Attack = mass[enemy.target].buffAtack;
                    mass[enemy.target].hodPas = 0;
                }
            }
        }
    }
}
