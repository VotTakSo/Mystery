using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public abstract class Creature
    {
        protected Attack attack;
        public string name;
        public int maxHp;
        public int Hp;
        public int Attack=0;
        public string img;
        public int poleNumber;
        public int hodPas = 0;
        public int hodLive = 0;
        public int poleNumberVS;
        public int buffAtack;

        public int manaCost;

        public string Element;
        public Player master;
        public Player enemy;

        public int armor = 0;


        public Creature[] perfomAttack(Creature[] mass, Creature cre,Player enemy)
        {
            return attack.Damage(mass, cre,enemy);
        }

     //   public abstract Creature[] Damage(Creature[] mass, Creature cre);
        public abstract void ActionAfterDeath(Creature[] mass, Player first, Player second);
        public abstract void ActionEveryStep();
        public abstract void ActionAtBegin(Creature[] mass, Player first, Player second);
    }
}
