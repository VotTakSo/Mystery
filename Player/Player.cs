using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery
{
    public class Player
    {
        static public int lvl=9;
        
        public int HP = 72;
        public int astralPower = 14;
        public int skillPoint = lvl - 5;
        public int fire = 5, wind = 3, water = 4, earth = 4, death = 4;
        public bool first=true;

        Weapon weapon;
        ShieldInterface shield;
        CloackInterface cloack;
        BootsInterface boots;
        AmuletInterface amulet;
        RingInterface ring;
        RuneInterface rune1;
        RuneInterface rune2;
        RuneInterface rune3;

        public Creature[] Weapon(Creature[] cre, int mana, int min, int max)
        {
            return weapon.Weapon(cre, mana, min , max);
        }
        public int Shield(Player first, string Element)
        {
            return shield.shield(first, Element);
        }
        public Creature Cloack(Creature cre, Player pl)
        {
            return cloack.Cloack(cre, pl);      
        }
        public Creature ReturnAttack(Creature cre)
        {
            return cloack.ReturnAttack(cre);
        }
        public Player Amulet(Player pl)
        {
            return amulet.Amulet(pl);
        }
        public Creature[] Ring(Creature[] cre, int min, int max)
        {
            return ring.Ring(cre, min, max);
        }
        public Player Boots(Player pl, string bootsMana)
        {
            return boots.Boots(pl, bootsMana);
        }
        public Player Rune1(Player pl, string runeElement)
        {
            return rune1.Rune(pl, runeElement);
        }
        public Player Rune2(Player pl, string runeElement)
        {
            return rune2.Rune(pl, runeElement);
        }
        public Player Rune3(Player pl, string runeElement)
        {
            return rune3.Rune(pl, runeElement);
        }

        public void setWeapon(Weapon w)
        {
            weapon = w;
        }
        public void setShield(ShieldInterface s)
        {
            shield = s;
        }
        public void setCloack(CloackInterface c)
        {
            cloack = c;
        }
        public void setAmulet(AmuletInterface a)
        {
            amulet = a;
        }
        public void setBoots(BootsInterface b)
        {
            boots = b;
        }
        public void setRing(RingInterface r)
        {
            ring = r;
        }
        public void setRune1(RuneInterface r)
        {
            rune1 = r;
        }
        public void setRune2(RuneInterface r)
        {
            rune2 = r;
        }
        public void setRune3(RuneInterface r)
        {
            rune3 = r;
        }

        public string weaponElements;
        public string bootsElements;
        public string shieldElements;
        public string runeElement1;
        public string runeElement2;
        public string runeElement3;
        public int shieldBuff;
        public bool boolCloack = false;

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
            boolCloack = clo;
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
    /*    public Player(bool hod, string weaponElement, string bootsElement, string shieldElement, bool clo)
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
        }*/
    }
}
