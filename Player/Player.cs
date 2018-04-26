using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public class Player
    {
        public int HP = 72;
        public int astralPower = 16;
        public int fire = 5, wind = 3, water = 4, earth = 4, death = 4;
        public bool first=true;

        Weapon weapon;
        ShieldInterface shield;

        public Creature[] Weapon(Creature[] cre, int mana, int min, int max)
        {
            return weapon.Weapon(cre, mana, min , max);
        }

        public int Shield(Player first, string Element)
        {

            return shield.shield(first, Element);
        }

        public void setWeapon(Weapon w)
        {
            weapon = w;
        }

        public void setShield(ShieldInterface s)
        {
            shield = s;
        }

        public string weaponElements;
        public string bootsElements;
        public string shieldElements;
        public int shieldBuff;
        public bool cloack = false;

        public Player()
        {
            first = true;
        }
        public Player(bool hod)
        {
            first = hod;
        }
        public Player(bool hod, string weaponElement, string bootsElement)
        {
            first = hod;
            weaponElements = weaponElement;
            bootsElements = bootsElement;
        }
        public Player(bool hod, string weaponElement, string bootsElement, bool clo)
        {
            first = hod;
            weaponElements = weaponElement;
            bootsElements = bootsElement;
            cloack = clo;
        }
        public Player(bool hod, string weaponElement, string bootsElement, string shieldElement)
        {
            first = hod;
            weaponElements = weaponElement;
            bootsElements = bootsElement;
            shieldElements = shieldElement;
        }
        public Player(bool hod, string weaponElement, string bootsElement, string shieldElement, int buff)
        {
            first = hod;
            weaponElements = weaponElement;
            bootsElements = bootsElement;
            shieldElements = shieldElement;
            shieldBuff = buff;
        }
        public Player(bool hod, string weaponElement, string bootsElement, string shieldElement, bool clo)
        {
            first = hod;
            weaponElements = weaponElement;
            bootsElements = bootsElement;
            shieldElements = shieldElement;
            cloack = clo;
        }
        public Player(bool hod, string weaponElement, string bootsElement, string shieldElement, int buff, bool clo)
        {
            first = hod;
            weaponElements = weaponElement;
            bootsElements = bootsElement;
            shieldElements = shieldElement;
            shieldBuff = buff;
            cloack = clo;
        }
    }
}
