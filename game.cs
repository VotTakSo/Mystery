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

        public Game(MainWindow w)
        {

            mrTorry.weaponElements = w.weaponElement;
            mrTorry.shieldElements = w.shieldElement;
            mrTorry.bootsElements = w.bootsElement;
            enemy.shieldElements = w.shieldElement;
            if (w.weaponFlag)
            {
                switch (w.weaponNumber)
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

            if (w.shieldFlag)
            {
                switch (w.shieldNumber)
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


            if (w.cloackFlag)
            {
                mrTorry.setCloack(new CloackOfVipers());
            }
            else
                mrTorry.setCloack(new NoCloack());

            if (w.bootsFlag)
            {
                mrTorry.setBoots(new ElementBoots());
            }
            else
            {
                mrTorry.setBoots(new NoBoots());
            }
            mrTorry.Boots(mrTorry, w.bootsElement);

            if(w.amuletFlag)
            {
                switch (w.amuletNumber)
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

            if (w.ringFlag)
            {
                switch (w.ringNumber)
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

            // enemy.setShield(new Shield());
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
                    if(mrTorry.first)
                    Armor = mrTorry.Shield(mrTorry, Goblin.Element);
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
                   // else Armor = enemy.Shield(enemy, Ghost.Element);
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
