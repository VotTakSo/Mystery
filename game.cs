using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mystery
{
    public class Game : Mechanics
    {
        public void LoadImage(Image i, string s)
        {
            Uri uri = new Uri(s);
            BitmapImage bitmap = new BitmapImage(uri);
            i.Source = bitmap;
        }
        public bool rune1flag, rune2flag, rune3flag, Player2rune1flag, Player2rune2flag, Player2rune3flag;
        public Player setWeapon(Player mrTorry, bool weaponFlag, int weaponNumber)
        {
            if (weaponFlag)
            {
                switch (weaponNumber)
                {
                    case 1:
                        {
                            mrTorry.setWeapon(new Bow());
                            break;
                        }
                    case 2:
                        {
                            mrTorry.setWeapon(new Splinter());
                            break;
                        }
                }
            }
            else
                mrTorry.setWeapon(new NoWeapon());
            return mrTorry;
        }
        public Player setShield(Player mrTorry, bool shieldFlag, int shieldNumber)
        {
            if (shieldFlag)
            {
                switch (shieldNumber)
                {
                    case 1:
                        {
                            mrTorry.setShield(new Shield());
                            break;
                        }
                    case 2:
                        {
                            mrTorry.setShield(new BigShield());
                            break;
                        }
                    case 3:
                        {
                            mrTorry.setShield(new OrksShield());
                            break;
                        }

                }
            }
            else
                mrTorry.setShield(new NoShield());
            return mrTorry;
        }
        public Player setCloack(Player mrTorry, bool cloackFlag)
        {
            if (cloackFlag)
            {
                mrTorry.setCloack(new CloackOfVipers());
            }
            else
                mrTorry.setCloack(new NoCloack());
            return mrTorry;
        }
        public Player setBoots(Player mrTorry, bool bootsFlag)
        {
            if (bootsFlag)
            {
                mrTorry.setBoots(new ElementBoots());
            }
            else
            {
                mrTorry.setBoots(new NoBoots());
            }
            return mrTorry;
        }
        public Player setAmulet(Player mrTorry, bool amuletFlag, int amuletNumber)
        {
            if (amuletFlag)
            {
                switch (amuletNumber)
                {
                    case 1:
                        {
                            mrTorry.setAmulet(new Cross());
                            break;
                        }
                }
            }
            else
            {
                mrTorry.setAmulet(new NoAmulet());
            }
            return mrTorry;
        }
        public Player setRing(Player mrTorry, bool ringFlag, int ringNumber)
        {
            if (ringFlag)
            {
                switch (ringNumber)
                {
                    case 1:
                        {
                            mrTorry.setRing(new OrksRing());
                            break;
                        }
                }
            }
            else
            {
                mrTorry.setRing(new NoRing());
            }
            return mrTorry;
        }
        public Player setRune1(Player mrTorry, bool runeFlag1, int runeNumber1)
        {
            if (runeFlag1)
            {
                switch (runeNumber1)
                {
                    case 1:
                        {
                            mrTorry.setRune1(new PotionRune());
                            break;
                        }
                    case 2:
                        {
                            mrTorry.setRune1(new HealRune());
                            break;
                        }
                    case 3:
                        {
                            mrTorry.setRune1(new ElementRune());
                            break;
                        }
                }
            }
            else
            {
                mrTorry.setRune1(new NoRune());
            }
            return mrTorry;
        }
        public Player setRune2(Player mrTorry, bool runeFlag2, int runeNumber2)
        {
            if (runeFlag2)
            {
                switch (runeNumber2)
                {
                    case 1:
                        {
                            mrTorry.setRune2(new PotionRune());
                            break;
                        }
                    case 2:
                        {
                            mrTorry.setRune2(new HealRune());
                            break;
                        }
                    case 3:
                        {
                            mrTorry.setRune2(new ElementRune());
                            break;
                        }
                }
            }
            else
            {
                mrTorry.setRune2(new NoRune());
            }
            return mrTorry;
        }
        public Player setRune3(Player mrTorry, bool runeFlag3, int runeNumber3)
        {
            if (runeFlag3)
            {
                switch (runeNumber3)
                {
                    case 1:
                        {
                            mrTorry.setRune3(new PotionRune());
                            break;
                        }
                    case 2:
                        {
                            mrTorry.setRune3(new HealRune());
                            break;
                        }
                    case 3:
                        {
                            mrTorry.setRune3(new ElementRune());
                            break;
                        }
                }
            }
            else
            {
                mrTorry.setRune3(new NoRune());
            }
            return mrTorry;
        }
        public Player setElementSkill(Player mrTorry, bool skillElement)
        {
            if(skillElement)
            {
                mrTorry.setElementSkill(new ElementBuff());
            }
            else
            {
                mrTorry.setElementSkill(new NoElementSkill());
            }
            return mrTorry;
        }
        public Player setSkill(Player mrTorry, bool skillElement, string element)
        {
            if (skillElement)
            {
                switch (element)
                {
                    case ("fire"):
                        {
                            mrTorry.setSkill(new FireAura());
                            break;
                        }
                    
                    case ("water"):
                        {
                            mrTorry.setSkill(new DepthForce());
                            break;
                        }
                    case ("earth"):
                        {
                            mrTorry.setSkill(new EarthHeal());
                            break;
                        }
                    case ("death"):
                        {
                            mrTorry.setSkill(new Miasama());
                            break;
                        }
                }
                
            }
        
            else
            {
                mrTorry.setSkill(new NoSkill());
            }
            return mrTorry;
        }

        public Game(MainWindow w)
        {
            mrTorry.skill = w.Player1Skill;
            mrTorry.skillElement = w.Player1ElementSkill;
            mrTorry.skillLvl = w.Player1SkillLvl;
            mrTorry.skillElementLvl = w.Player1ElementSkillLvl;
            mrTorry.astralPower = w.Player1AstralPower;
            mrTorry.Element = w.Player1Element;
            mrTorry.HP = w.Player1HP;

            enemy.skill = w.Player2Skill;
            enemy.skillElement = w.Player2ElementSkill;
            enemy.skillLvl = w.Player2SkillLvl;
            enemy.skillElementLvl = w.Player2ElementSkillLvl;
            enemy.astralPower = w.Player2AstralPower;
            enemy.Element = w.Player2Element;
            enemy.HP = w.Player2HP;

            rune1flag = w.runeFlag1;
            rune2flag = w.runeFlag2;
            rune3flag = w.runeFlag3;

            Player2rune1flag = w.Player2runeFlag1;
            Player2rune2flag = w.Player2runeFlag2;
            Player2rune3flag = w.Player2runeFlag3;

            mrTorry.weaponElements = w.weaponElement;
            mrTorry.shieldElements = w.shieldElement;
            mrTorry.bootsElements = w.bootsElement;
            mrTorry.runeElement1 = w.runeElement1;
            mrTorry.runeElement2 = w.runeElement3;
            mrTorry.runeElement3 = w.runeElement3;

            enemy.weaponElements = w.Player2weaponElement;
            enemy.shieldElements = w.Player2shieldElement;
            enemy.bootsElements = w.Player2bootsElement;
            enemy.runeElement1 = w.Player2runeElement1;
            enemy.runeElement2 = w.Player2runeElement3;
            enemy.runeElement3 = w.Player2runeElement3;


            mrTorry = setRune1(mrTorry, w.runeFlag1, w.runeNumber1);
            enemy = setRune1(enemy, w.Player2runeFlag1, w.Player2runeNumber1);

            mrTorry = setRune2(mrTorry, w.runeFlag2, w.runeNumber2);
            enemy = setRune2(enemy, w.Player2runeFlag2, w.Player2runeNumber2);

            mrTorry = setRune3(mrTorry, w.runeFlag3, w.runeNumber3);
            enemy = setRune3(enemy, w.Player2runeFlag3, w.Player2runeNumber3);
         
            mrTorry = setWeapon(mrTorry, w.weaponFlag, w.weaponNumber);
            enemy = setWeapon(enemy, w.Player2weaponFlag, w.Player2weaponNumber);

            mrTorry = setShield(mrTorry, w.shieldFlag, w.shieldNumber);
            enemy = setShield(enemy, w.Player2shieldFlag, w.Player2shieldNumber);

            mrTorry = setCloack(mrTorry, w.cloackFlag);
            enemy = setCloack(enemy, w.Player2cloackFlag);

            mrTorry = setBoots(mrTorry, w.bootsFlag);
            enemy = setBoots(enemy, w.Player2bootsFlag);
            mrTorry.Boots(mrTorry, w.bootsElement);
            enemy.Boots(enemy, w.Player2bootsElement);

            mrTorry = setAmulet(mrTorry, w.amuletFlag, w.amuletNumber);
            enemy = setAmulet(enemy, w.Player2amuletFlag, w.Player2amuletNumber);

            mrTorry = setRing(mrTorry, w.ringFlag, w.ringNumber);
            enemy = setRing(enemy, w.Player2ringFlag, w.Player2ringNumber);

            mrTorry = setElementSkill(mrTorry, w.Player1ElementSkill);
            enemy = setElementSkill(enemy, w.Player2ElementSkill);
            mrTorry.ElementSkill(mrTorry, mrTorry.skillElementLvl, mrTorry.Element);
            enemy.ElementSkill(enemy, enemy.skillElementLvl, enemy.Element);

            mrTorry = setSkill(mrTorry, w.Player1Skill, w.Player1Element);
            enemy= setSkill(enemy, w.Player2Skill, w.Player2Element);

            wind = w;
           

            
        }
        int Armor;
        
        public void wTest ()
            {
            LoadImage(wind.weaponImg, wind.weaponImage);
        }
        
      
        Creature Master(Creature cre)
        {
            if (mrTorry.first) { cre.master = mrTorry; cre.enemy = enemy; } else { cre.master = enemy; cre.enemy = mrTorry; }
            return cre;
        }
        //********************************************************************//
        int buffArmor = 0;
        //Карты
        public void card()
        {
        }

        int PlayerMana(Player pl, Creature cre)
        {
            int mana = 0;
            switch(cre.Element)
            {
                case "fire":
                    {
                        mana = pl.fire;
                        break;
                    }
                case "wind":
                    {
                        mana = pl.wind;
                        break;
                    }
                case "water":
                    {
                        mana = pl.water;
                        break;
                    }
                case "earth":
                    {
                        mana = pl.earth;
                        break;
                    }
                case "death":
                    {
                        mana = pl.death;
                        break;
                    }
            }
            return mana;
        }
        int PlayerMana(Player pl, Spell cre)
        {
            int mana = 0;
            switch (cre.Element)
            {
                case "fire":
                    {
                        mana = pl.fire;
                        break;
                    }
                case "wind":
                    {
                        mana = pl.wind;
                        break;
                    }
                case "water":
                    {
                        mana = pl.water;
                        break;
                    }
                case "earth":
                    {
                        mana = pl.earth;
                        break;
                    }
                case "death":
                    {
                        mana = pl.death;
                        break;
                    }
            }
            return mana;
        }
        Player ReturnPlayerMana(Player pl, Creature cre, int mana)
        {
            
            switch (cre.Element)
            {
                case "fire":
                    {
                        pl.fire=mana;
                        break;
                    }
                case "wind":
                    {
                        pl.wind = mana;
                        break;
                    }
                case "water":
                    {
                        pl.water = mana;
                        break;
                    }
                case "earth":
                    {
                        pl.earth = mana;
                        break;
                    }
                case "death":
                    {
                        pl.death = mana;
                        break;
                    }
            }
            return pl;
        }

        public Spell a;
        public void EndTarget()
        {
            if (mass[wind.targetNumber] != null)
            {
                mrTorry.target = wind.targetNumber;
                enemy.target = wind.targetNumber;

                a.Action(mass, mrTorry, enemy);
                EndChooseTarget();
                CreatureDeth(mass[wind.targetNumber]);
                //ReturnAttack();

                wind.targetNumber = 0;
                EndLogic();
            }
            else
            {
                wind.ErrorTarget();
            }
        }
        //Огонь
        public void Goblin()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Goblin(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element)+mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element)+enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void FireWall()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new FireWall(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element)+mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element)+enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Infernal()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Infernal(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element)+mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element)+enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Meteor()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Meteorite();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                if (mrTorry.first)
                    spell.Action(mass, mrTorry, enemy);
                else
                    spell.Action(mass, enemy, mrTorry);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Inferno()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Inferno();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Scorpio()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Scorpio(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        //Воздух
        public void Storm()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Storm();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Assasin()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Assasin(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Gargoule()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Gargoyle(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element);
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element);
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Sabbath()
        {
            Spell cast = new Sabbath();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Discharge()
        {
            Spell cast = new Discharge();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void ChainLightning()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new ChainLightning();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        //Вода
        public void Triton()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Triton(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void SeaSnake()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new SeaSnake(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void TargetHeal()
        {
            Spell cast = new TargetHeal();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Heal()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Heal();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void ElementVortex()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new ElementalVortex();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void IceMonster()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new IceMonster(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void CallOfTheSirens()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new CallOfTheSirens();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        //Земля
        public void Druid()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Druid(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Prostration()
        {
            Spell cast = new Prostraion();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void EarthWorms()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new EarthWorms();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Frog()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Frog();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Dendroid()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Dendroid(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void AncientMonster()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new AncientMonster(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Kramola()
        {
            Spell cast = new Kramola();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        //Смерть
        public void Demoralization()
        {
            Spell cast = new Demoralization();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Damnation()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Damnation();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Ghost()
        {
            int playerMana = 0;
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Ghost(wind.poleNumber, VsPole(wind.poleNumber));
                playerMana = PlayerMana(firstPlayer, cre);
                if (playerMana >= cre.manaCost)
                {
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;

                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    playerMana -= cre.manaCost;
                    firstPlayer = ReturnPlayerMana(firstPlayer, cre, playerMana);
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Weakness()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Weakness();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Decomposition()
        {
            Spell cast = new Decomposition();
            int playerMana = 0;
            spellNumber = 1;
            StartLogic();
            playerMana = PlayerMana(firstPlayer, cast);
            if (playerMana >= cast.manaCast)
            {
                if (mrTorry.first)
                {
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                }
                else
                {
                    wind.ChooseGrid.Visibility = Visibility.Visible;
                    wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                    wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                }
                AllCollapsed();
                ElementsGridCollapsed();
                a = cast;
            }
            else
            {
                wind.ErrorMana();
            }
        }
        public void Regeneration()
        {
            int playerMana = 0;
            StartLogic();
            Spell spell = new Regeneration();
            playerMana = PlayerMana(firstPlayer, spell);
            if (playerMana >= spell.manaCast)
            {
                spell.Action(mass, mrTorry, enemy);
                EndLogic();
            }
            else
            {
                wind.ErrorMana();
            }
        }
        //Нейтральная
        public void Fairy()
        {
            
            StartLogic();
            if (wind.poleNumber != 0)
            {
                Creature cre = new Fairy(wind.poleNumber, VsPole(wind.poleNumber));
               
               
                    //Добавление защиты с учетом щита
                    if (mrTorry.first) Armor = buffArmor + mrTorry.Shield(mrTorry, cre.Element) + mrTorry.armor;
                    else Armor = buffArmor + enemy.Shield(enemy, cre.Element) + enemy.armor;
                    cre.armor += Armor;
                    Armor = 0;
                    cre.ActionAtBegin(mass, firstPlayer, secondPlayer);
                    Master(cre);
                    mass[wind.poleNumber] = cre;

                    LoadImage(cre.poleNumber, cre.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                   
                    
                   
                    EndLogic();
               
            }
            else
            {
                wind.ErrorPole();
            }
        }
        public void Quicksand()
        {
            //StartLogic();
            //Spell spell = new Quicksand();
            //if ()
            //{
            //    spell.Action(mass, mrTorry, enemy);
            //    EndLogic();
            //}
            //else
            //{
            //    wind.ErrorMana();
            //}
        }
        //

        //********************************************************************//
        public void rune1()
        {
            mrTorry.Rune1(mrTorry, wind.runeElement1);
            Refresh();
            rune1flag = false;
        }
        public void rune2()
        {
            mrTorry.Rune2(mrTorry, wind.runeElement2);
            Refresh();
            rune2flag = false;
        }
        public void rune3()
        {
            mrTorry.Rune3(mrTorry, wind.runeElement3);
            Refresh();
            rune3flag = false;
        }

        public void Player2rune1()
        {
            enemy.Rune1(enemy, wind.Player2runeElement1);
            Refresh();
            rune1flag = false;
        }
        public void Player2rune2()
        {
            enemy.Rune2(enemy, wind.Player2runeElement2);
            Refresh();
            rune2flag = false;
        }
        public void Player2rune3()
        {
            enemy.Rune3(enemy, wind.Player2runeElement3);
            Refresh();
            rune3flag = false;
        }
        //***************************************************************//
        //Пропуск хода
        public void Pas()
        {
            StartLogic();
            EndLogic();
        }

        public void GetUp()
        {
            StartLogic();
            if(mrTorry.first)
            {
                mrTorry.HP = 0;
            }
            else
            {
                enemy.HP = 0;

            }
            EndLogic();
        }
    }
}
