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
    public class Mechanics
    {
        protected MainWindow wind;

        protected Artefact art = new Artefact();
        //Массив всех существ
        public Creature[] mass = new Creature[11];

        protected Player mrTorry = new Player(true, "mrTorry");
        
        protected Player enemy = new Player(false, "enemy");
        
        
        //буферные
        protected Player firstPlayer = new Player();
        protected Player secondPlayer = new Player();

        //********************************************************************//
        //Работа с полем
        //Делают поля видимыми в начале хода 
        public void AllCollapsed()
        {
            

            wind.pole1.Visibility = Visibility.Collapsed;
            wind.pole2.Visibility = Visibility.Collapsed;
            wind.pole3.Visibility = Visibility.Collapsed;
            wind.pole4.Visibility = Visibility.Collapsed;
            wind.pole5.Visibility = Visibility.Collapsed;

            wind.pole6.Visibility = Visibility.Collapsed;
            wind.pole7.Visibility = Visibility.Collapsed;
            wind.pole8.Visibility = Visibility.Collapsed;
            wind.pole9.Visibility = Visibility.Collapsed;
            wind.pole10.Visibility = Visibility.Collapsed;
        }
        public void SecondPlayerPoleVisible()
        {
            if (!wind.poleBuffer[6]) wind.pole6.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[7]) wind.pole7.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[8]) wind.pole8.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[9]) wind.pole9.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[10]) wind.pole10.Visibility = Visibility.Visible;
        }
        public void FirstPlayerPoleVisible()
        {
            if (!wind.poleBuffer[1]) wind.pole1.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[2]) wind.pole2.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[3]) wind.pole3.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[4]) wind.pole4.Visibility = Visibility.Visible;
            if (!wind.poleBuffer[5]) wind.pole5.Visibility = Visibility.Visible;

        }

        //********************************************************************//
        //Работа с картами. Используется в Refresh
        //Все карты невидимы
        public void ElementsGridCollapsed()
        {
            wind.fireGrid.Visibility = System.Windows.Visibility.Collapsed;
            wind.WindGrid.Visibility = System.Windows.Visibility.Collapsed;
            wind.WaterGrid.Visibility = System.Windows.Visibility.Collapsed;
            wind.EarthGrid.Visibility = System.Windows.Visibility.Collapsed;
            wind.DethGrid.Visibility = System.Windows.Visibility.Collapsed;
            wind.NeitralGrid.Visibility = Visibility.Collapsed;

        }
        //Выбор стихии карт
        public void Elements()
        {
            ElementsGridCollapsed();
            if (wind.fireButton.IsChecked == true) wind.fireGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.windButton.IsChecked == true) wind.WindGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.waterButton.IsChecked == true) wind.WaterGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.earthButton.IsChecked == true) wind.EarthGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.dethButton.IsChecked == true) wind.DethGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.neitralButton.IsChecked == true) wind.NeitralGrid.Visibility = System.Windows.Visibility.Visible;


        }
        public void EnemyElements()
        {
            ElementsGridCollapsed();

            if (wind.fireEnemyButton.IsChecked == true) wind.fireGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.windEnemyButton.IsChecked == true) wind.WindGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.waterEnemyButton.IsChecked == true) wind.WaterGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.earthEnemyButton.IsChecked == true) wind.EarthGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.dethEnemyButton.IsChecked == true) wind.DethGrid.Visibility = System.Windows.Visibility.Visible;

            if (wind.neitralEnemyButton.IsChecked == true) wind.NeitralGrid.Visibility = System.Windows.Visibility.Visible;

        }

        //********************************************************************//     

        //Определение какую клетку будет атаковать существо напротив
        public int VsPole(int a)
        {
            int b = a;
            switch (a)
            {
                case 1:
                    {
                        b = 6;
                        break;
                    }
                case 2:
                    {
                        b = 7;
                        break;
                    }
                case 3:
                    {
                        b = 8;
                        break;
                    }
                case 4:
                    {
                        b = 9;
                        break;
                    }
                case 5:
                    {
                        b = 10;
                        break;
                    }
                case 6:
                    {
                        b = 1;
                        break;
                    }
                case 7:
                    {
                        b = 2;
                        break;
                    }
                case 8:
                    {
                        b = 3;
                        break;
                    }
                case 9:
                    {
                        b = 4;
                        break;
                    }
                case 10:
                    {
                        b = 5;
                        break;
                    }
            }
            return b;
        }
        //загружает изображение в выбранное поле
        public void LoadImage(int a, string s)
        {
            wind.poleBuffer[a] = true;
            Uri uri = new Uri(s);
            BitmapImage bitmap = new BitmapImage(uri);
            Image img = new Image();

            switch (a)
            {
                case 1:
                    {
                        wind.pole1Img.Source = bitmap;
                        break;
                    }

                case 2:
                    {
                        wind.pole2Img.Source = bitmap;
                        break;
                    }
                case 3:
                    {
                        wind.pole3Img.Source = bitmap;
                        break;
                    }

                case 4:
                    {
                        wind.pole4Img.Source = bitmap;
                        break;
                    }

                case 5:
                    {
                        wind.pole5Img.Source = bitmap;
                        break;
                    }

                case 6:
                    {
                        wind.pole6Img.Source = bitmap;
                        break;
                    }
                case 7:
                    {
                        wind.pole7Img.Source = bitmap;
                        break;
                    }

                case 8:
                    {
                        wind.pole8Img.Source = bitmap;
                        break;
                    }

                case 9:
                    {
                        wind.pole9Img.Source = bitmap;
                        break;
                    }

                case 10:
                    {
                        wind.pole10Img.Source = bitmap;
                        break;
                    }

            }
        }

        //********************************************************************//
        //Для StartLogic
        //Определение кто ходит первый
        public void Choose(out Player first, out Player second)
        {
            if (mrTorry.first)
            {
                first = mrTorry;
                second = enemy;
            }
            else
            {
                second = mrTorry;
                first = enemy;
            }
        }

        //********************************************************************//
        // Для EndLogic

        //Обновление поля
        public void Refresh()
        {
            AllCollapsed();
            if (mrTorry.first)
            {
                wind.Hod.Content = "Первый игрок ходит";
                FirstPlayerPoleVisible();
                wind.firstPlayerRB.Visibility = Visibility.Visible;
                wind.secondPlayerRB.Visibility = Visibility.Collapsed;
                Elements();
                if (wind.runeFlag1 && mrTorry.first)
                {
                    wind.RuneSlot1.Visibility = Visibility.Visible;
                }
                if (wind.runeFlag2 && mrTorry.first)
                {
                    wind.RuneSlot2.Visibility = Visibility.Visible;
                }
                if (wind.runeFlag3 && mrTorry.first)
                {
                    wind.RuneSlot3.Visibility = Visibility.Visible;
                }
            }
            else
            {
                wind.Hod.Content = "Второй игрок ходит";
                SecondPlayerPoleVisible();
                wind.firstPlayerRB.Visibility = Visibility.Collapsed;
                wind.secondPlayerRB.Visibility = Visibility.Visible;
                EnemyElements();
            }
            wind.fireEnemyMana.Content = enemy.fire;
            wind.windEnemyMana.Content = enemy.wind;
            wind.waterEnemyMana.Content = enemy.water;
            wind.earthEnemyMana.Content = enemy.earth;
            wind.dethEnemyMana.Content = enemy.death;
            wind.Hp.Content = mrTorry.HP;
            wind.EnemyHp.Content = enemy.HP;
            wind.fireMana.Content = mrTorry.fire;
            wind.windMana.Content = mrTorry.wind;
            wind.waterMana.Content = mrTorry.water;
            wind.earthMana.Content = mrTorry.earth;
            wind.dethMana.Content = mrTorry.death;
            EndChooseTarget();

          

            if (wind.Player2runeFlag1 && !mrTorry.first)
            {
                wind.Player2RuneSlot1.Visibility = Visibility.Visible;
            }
            if (wind.Player2runeFlag2 && !mrTorry.first)
            {
                wind.Player2RuneSlot2.Visibility = Visibility.Visible;
            }
            if (wind.Player2runeFlag3 && !mrTorry.first)
            {
                wind.Player2RuneSlot3.Visibility = Visibility.Visible;
            }
        }

        //Возврат данных в глобальные 
        public void Check(Player first, Player second)
        {
            if (mrTorry.first)
            {
                mrTorry = first;
                enemy = second;

            }
            else
            {
                mrTorry = second;
                enemy = first;
            }
        }

        //Смена хода
        public void Change()
        {
            if (mrTorry.first) mrTorry.first = false;
            else mrTorry.first = true;
        }

        //добавление маны в начале хода
        public void ManaAdd(Player pl)
        {
            pl.fire++;
            pl.wind++;
            pl.water++;
            pl.earth++;
            pl.death++;
        }


        //********************************************************************//

        //Урон от оружия
        public void DmgWeapon()
        {
            int mana;
            mana = ChooseElement(secondPlayer.weaponElements, firstPlayer);
            if (!mrTorry.first)
            {
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                        mrTorry.PlayerSkill(mass, mass[i], enemy, mrTorry.skillLvl);
                }
                for (int i = 6, j = 1; i < 11; i++, j++)
                {
                    if (mass[i] != null)
                    {
               
                        mrTorry.Weapon(mass, mana, 1, 6); //Последний параметр будет меняться в зависимости от выбраного артефакта
                        // art.DamageBow( mass, secondPlayer.water, i, 11); //Последний параметр будет меняться в зависимости от выбраного артефакта
                        // art.Damage(mass, mana, 1, 6); //Последний параметр будет меняться в зависимости от выбраного артефакта
                        // art.Ring(mass, i, 11);
                        mrTorry.Ring(mass, 6, 11);
                        break;
                    }
                }

            }
            else
            {
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                        enemy.PlayerSkill(mass, mass[i], mrTorry, enemy.skillLvl);
                }
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        enemy.Weapon(mass, mana, 6, 11);
                        //art.DamageBow(mass, secondPlayer.water, i, 6); //Последний параметр будет меняться в зависимости от выбраного артефакта
                        // art.Damage(mass, mana, 6, 11); //Последний параметр будет меняться в зависимости от выбраного артефакта
                        // art.Ring(mass, 1, 6);
                        enemy.Ring(mass, 1, 6);
                        break;
                    }
                }
            }
            for (int i = 1; i < 11; i++)
            {
                CreatureDeth(mass[i]);
            }
        }
        //Наносит урон существу напротив(или сопернику)
        Player damage(Creature cre, Player enemyPlayer)
        {
           
            
            if (cre != null)
            {

                if (cre.hodLive != 0)
                {
                    //if (mass[cre.poleNumberVS] != null)
                    //{

                    //  mass[cre.poleNumberVS].Hp -= (cre.Attack-mass[cre.poleNumberVS].armor);
                    mass = cre.perfomAttack(mass, cre, enemyPlayer);
                    //art.CloackOfVipersReturnAttack(cre);
                    //art.CloackOfVipersReturnAttack(mass[cre.poleNumberVS]);
                    mrTorry.ReturnAttack(cre);
                    //}
                    //else
                    //{
                    //      enemyPlayer.HP -= cre.Attack;
                    //art.CloackOfVipersReturnAttack(cre);
                    //art.CloackOfVipersReturnAttack(mass[cre.poleNumberVS]);
                   // mrTorry.ReturnAttack(cre);
                    //}
                }
               
                cre.hodLive++;
            }
            
            return enemyPlayer;
        }
        //Механика взаимодействия противоположных карт в конце хода
        protected void Mex()

        {
            
            if (mrTorry.first)
            {
                for (int i = 1; i < 6; i++)
                {
                    CreatureDeth(mass[i]);
                    damage(mass[i], secondPlayer);
                    CreatureDeth(mass[i]);
                }
            }
            else
            {
                for (int i = 6; i < 11; i++)
                {
                    CreatureDeth(mass[i]);
                    damage(mass[i], secondPlayer);
                    CreatureDeth(mass[i]);
                }
            }
            DmgWeapon();
            ReturnAttack();
        }
        //Убираеет атаку и жизни мертвых сущетв
        protected void CreatureHPAttackDeth(int a)
        {
            switch (a)
            {
                case 1:
                    {
                        wind.label1HP.Content ="";
                        wind.label1Attack.Content ="";
                        break;
                    }
                case 2:
                    {
                        wind.label2HP.Content = "";
                        wind.label2Attack.Content = "";
                        break;
                    }
                case 3:
                    {
                        wind.label3HP.Content = "";
                        wind.label3Attack.Content = "";
                        break;
                    }
                case 4:
                    {
                        wind.label4HP.Content = "";
                        wind.label4Attack.Content = "";
                        break;
                    }
                case 5:
                    {
                        wind.label5HP.Content = "";
                        wind.label5Attack.Content = "";
                        break;
                    }
                case 6:
                    {
                        wind.label6HP.Content = "";
                        wind.label6Attack.Content = "";
                        break;
                    }
                case 7:
                    {
                        wind.label7HP.Content = "";
                        wind.label7Attack.Content = "";
                        break;
                    }
                case 8:
                    {
                        wind.label8HP.Content = "";
                        wind.label8Attack.Content = "";
                        break;
                    }
                case 9:
                    {
                        wind.label9HP.Content = "";
                        wind.label9Attack.Content = "";
                        break;
                    }
                case 10:
                    {
                        wind.label10HP.Content = "";
                        wind.label10Attack.Content = "";
                        break;
                    }
            }
        }
        //Смерть существа
        protected void CreatureDeth(Creature cre)
        {
            if (cre != null)
            {
                if (mass[cre.poleNumber] != null)
                    if (mass[cre.poleNumber].Hp <= 0)
                    {
                        //Тут может быть ошибка при смерти своего существа в свой ход... А может и не быть :)
                        mass[cre.poleNumber].ActionAfterDeath(mass, mrTorry, enemy);
                        CreatureHPAttackDeth(cre.poleNumber);
                        mass[cre.poleNumber].img = "pack://application:,,,/Resources/Creatures/fon.jpg";
                        LoadImage(mass[cre.poleNumber].poleNumber, mass[cre.poleNumber].img);
                        wind.poleBuffer[cre.poleNumber] = false;
                        mass[cre.poleNumber] = null;
                        // art.CloackOfVipers(mass[cre.poleNumberVS], firstPlayer);
                        if (!mrTorry.first) mrTorry.Cloack(mass[cre.poleNumber], firstPlayer);
                        else enemy.Cloack(mass[cre.poleNumberVS], secondPlayer);
                    }
                if (mass[cre.poleNumberVS] != null)
                    if (mass[cre.poleNumberVS].Hp <= 0)
                    {
                        mass[cre.poleNumberVS].ActionAfterDeath(mass, mrTorry, enemy);
                        CreatureHPAttackDeth(cre.poleNumberVS);
                        mass[cre.poleNumberVS].img = "pack://application:,,,/Resources/Creatures/fon.jpg";
                        LoadImage(mass[cre.poleNumberVS].poleNumber, mass[cre.poleNumberVS].img);
                        wind.poleBuffer[cre.poleNumberVS] = false;
                        mass[cre.poleNumberVS] = null;
                        // art.CloackOfVipers(mass[cre.poleNumber], secondPlayer);
                        if (!mrTorry.first) mrTorry.Cloack(mass[cre.poleNumber], secondPlayer);
                        else enemy.Cloack(mass[cre.poleNumber], firstPlayer);

                    }

            }
        }

        //********************************************************************//
     
        //
        public void StartLogic()
        {

            
            if (!mrTorry.first)
            {
                mrTorry.Amulet(mrTorry);
                for (int i = 1; i < 6; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].ActionEveryStep();
                    }
                }
            }
            else
            {
                enemy.Amulet(enemy);
                for (int i = 6; i < 11; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].ActionEveryStep();
                    }
                }
            }
            Choose(out firstPlayer, out secondPlayer);
           
            

        }
        //
        public void EndLogic()
        {
            Mex();
            HpAttack();
            ManaAdd(secondPlayer);
            Check(firstPlayer, secondPlayer);
            Change();
            Refresh();
            if(!mrTorry.first)
            {
                wind.RuneSlot1.Visibility = Visibility.Hidden;
                wind.RuneSlot2.Visibility = Visibility.Hidden;
                wind.RuneSlot3.Visibility = Visibility.Hidden;
            }
            wind.End(mrTorry, enemy);
           
        }

    
        //*********************************************************************//

        public void HpAttack()
        {
            if (mass[1] != null)
            {
                wind.label1HP.Content = mass[1].Hp+" HP";
                wind.label1Attack.Content = mass[1].Attack+" Attack";
            }

            if (mass[2] != null)
            {
                wind.label2HP.Content = mass[2].Hp + " HP";
                wind.label2Attack.Content = mass[2].Attack + " Attack";
            }

            if (mass[3] != null)
            {
                wind.label3HP.Content = mass[3].Hp + " HP";
                wind.label3Attack.Content = mass[3].Attack + " Attack";
            }

            if (mass[4] != null)
            {
                wind.label4HP.Content = mass[4].Hp + " HP";
                wind.label4Attack.Content = mass[4].Attack + " Attack";
            }

            if (mass[5] != null)
            {
                wind.label5HP.Content = mass[5].Hp + " HP";
                wind.label5Attack.Content = mass[5].Attack + " Attack";
            }

            if (mass[6] != null)
            {
                wind.label6HP.Content = mass[6].Hp + " HP";
                wind.label6Attack.Content = mass[6].Attack + " Attack";
            }

            if (mass[7] != null)
            {
                wind.label7HP.Content = mass[7].Hp + " HP";
                wind.label7Attack.Content = mass[7].Attack + " Attack";
            }

            if (mass[8] != null)
            {
                wind.label8HP.Content = mass[8].Hp + " HP";
                wind.label8Attack.Content = mass[8].Attack + " Attack";
            }

            if (mass[9] != null)
            {
                wind.label9HP.Content = mass[9].Hp + " HP";
                wind.label9Attack.Content = mass[9].Attack + " Attack";
            }

            if (mass[10] != null)
            {
                wind.label10HP.Content = mass[10].Hp + " HP";
                wind.label10Attack.Content = mass[10].Attack + " Attack";
            }
        }

        public void EndChooseTarget()
        {
            if (mrTorry.first)
            {
                wind.ChooseEnemyGrid.Visibility = Visibility.Collapsed;

            }
            else
            {
                wind.ChooseGrid.Visibility = Visibility.Collapsed;

            }
        }

        //*********************************************************************//

        int ChooseElement(string element, Player pl)
        {
            int mana=0;
            switch (element)
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
        
        public void ReturnAttack()
        {
            for (int i = 1; i < 11; i++)
            {
                art.CloackOfVipersReturnAttack(mass[i]);
            }
        }
        //public void GoblinActionAfterDeath(Creature cre)
        //{
        //    if (cre.master==mrTorry)
        //    {
        //        for (int i = 6; i < 11; i++)
        //        {
        //            if(mass[i]!=null)
        //            {
        //                mass[i].Hp -= 2;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 1; i < 6; i++)
        //        {
        //            if (mass[i] != null)
        //            {
        //                mass[i].Hp -= 2;
        //            }
        //        }
        //    }
        //}
        //public void GhostActionAfterDeath(Creature cre)
        //{
        //    if (cre.master==mrTorry)
        //    {
        //        enemy.HP -= 10;
        //    }
        //    else
        //    {
        //        mrTorry.HP -= 10;
        //    }
        //}
    }
}
