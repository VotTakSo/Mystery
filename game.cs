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
            return mrTorry;
        }

        public Game(MainWindow w)
        {
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



            wind = w;
           

            
        }
        int Armor;
        
        


        public void wTest ()
            {
            LoadImage(wind.weaponImg, wind.weaponImage);
        }
        
        //При выборе ячейки определяет какое заклинание воздействует на эту ячейку
        public void SpellCast()
        {
            switch (spellNumber)
            {
                case 1:
                    {
                        TargetSpell();
                        break;
                    }
            }
        }
        int spellNumber;
        Creature Master(Creature cre)
        {
            if (mrTorry.first) { cre.master = mrTorry; } else { cre.master = enemy; }
            return cre;
        }
//********************************************************************//
        //Карты
        public void card()
        {
            StartLogic();
            if (wind.poleNumber != 0)
                if (firstPlayer.fire > 3)
                {
                   
                    Goblin Goblin = new Goblin(wind.poleNumber, VsPole(wind.poleNumber));
                   
                    //Добавление защиты с учетом щита
                    if(mrTorry.first) Armor = mrTorry.Shield(mrTorry, Goblin.Element);
                    else Armor = enemy.Shield(enemy, Goblin.Element);
                    Goblin.armor += Armor;
                    Armor = 0;

                    Master(Goblin);
                    mass[wind.poleNumber] = Goblin;

                    LoadImage(Goblin.poleNumber, Goblin.img);

                    firstPlayer.water += 0;

                    wind.poleNumber = 0;
                    
                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            else
            {
                wind.ErrorPole();
            }

        }
        public void TargetSpell()
        {
            spellNumber = 1;
            StartLogic();
         
            //Проаерка маны
            if (firstPlayer.death > -100)
            {
               
                //Выбранао ли существо для взаимодействия
                if (wind.targetNumber == 0)
                {
                    if (mrTorry.first)
                    {
                        wind.ChooseEnemyGrid.Visibility = Visibility.Visible;
                        wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        wind.ChooseGrid.Visibility = Visibility.Visible;
                        wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                    }
                    AllCollapsed();
                    ElementsGridCollapsed();
                   
                }
                else
                //Если в выбранном поле есть существо
                if (mass[wind.targetNumber] != null)
                {
                    mass[wind.targetNumber].Hp -= (10- mass[wind.targetNumber].armor);
                   // firstPlayer.death -= 5;
                    secondPlayer.HP -= 10;


                    EndChooseTarget();

                    
                    CreatureDeth(mass[wind.targetNumber]);
                    ReturnAttack();

                    wind.targetNumber = 0;
                    EndLogic();
                }
                else
                {
                    wind.ErrorTarget();
                }
            }
            else
            {
                wind.ErrorMana();
            }

        }
     

        public void AllHeal()
        {
            StartLogic();
            if (firstPlayer.water > 8)
            {
                firstPlayer.HP += firstPlayer.water * 3;


                firstPlayer.water += 0;
                EndLogic();
            }
            else
            {
                wind.ErrorMana();

            }



        }


        public void ghost()
        {
            StartLogic();
            if (wind.poleNumber != 0)
                if (firstPlayer.death > 2)
                {
                    

                    Ghost Ghost = new Ghost(wind.poleNumber, VsPole(wind.poleNumber));

                    if (mrTorry.first) Armor = mrTorry.Shield(mrTorry, Ghost.Element);
                    else Armor = enemy.Shield(enemy, Ghost.Element);
                    Ghost.armor += Armor;
                    Armor = 0;

                    Master(Ghost);
                    mass[wind.poleNumber] = Ghost;
                

                    LoadImage(wind.poleNumber, Ghost.img);

                    firstPlayer.water += 0;
                    firstPlayer.death -= 3;

                    wind.poleNumber = 0;

                    EndLogic();
                }
                else
                {
                    wind.ErrorMana();
                }
            else
            {
                wind.ErrorPole();
            }

        }
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
