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
        public int Attack;
        public string img;
        public int poleNumber;
        public int hodPas = 0;
        public int hodLive = 0;
        public int poleNumberVS;
        public int buffAtack;

        public string Element;
        public Player master;

        public int armor = 0;


        public Creature[] perfomAttack(Creature[] mass, Creature cre,Player enemy)
        {
            return attack.Damage(mass, cre,enemy);
        }

     //   public abstract Creature[] Damage(Creature[] mass, Creature cre);
        public abstract void ActionAfterDeath(Creature[] mass, Player mrTorry, Player enemy);
    }
}
