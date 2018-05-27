using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    class TargetHeal:Spell
    {
        public TargetHeal()
        {
            Element = "water";
            manaCast = 5;
            img = "pack://application:,,,/Resources/Creatures/3.Water/TargetHeal.jpg";
        }
        public override void Action(Creature[] mass, Player mrTorry, Player enemy)
        {
            int heal = 0;

            if (mrTorry.first)
            {
                mrTorry.water -= manaCast;
                heal = 15;
                if (heal + mass[mrTorry.target].Hp > mass[mrTorry.target].maxHp)
                    mass[mrTorry.target].Hp = mass[mrTorry.target].maxHp;
                else
                    mass[mrTorry.target].Hp += heal;

            }
            else
            {
                enemy.water -= manaCast;
                heal = 15;
                if (heal + mass[enemy.target].Hp > mass[enemy.target].maxHp)
                    mass[enemy.target].Hp = mass[enemy.target].maxHp;
                else
                    mass[enemy.target].Hp += heal;
            }
        }
    }
}
