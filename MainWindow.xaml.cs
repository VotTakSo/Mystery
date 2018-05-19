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

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;

        static string artFon = "pack://application:,,,/Resources/Artefacts/test.jpg";

        public string runeElement1;
        public int runeNumber1;
        public bool runeFlag1 = false;
        public string runeImage1;

        public string runeElement2;
        public int runeNumber2;
        public bool runeFlag2 = false;
        public string runeImage2;

        public string runeElement3;
        public int runeNumber3;
        public bool runeFlag3 = false;
        public string runeImage3;

        public string weaponElement;
        public int weaponNumber;
        public bool weaponFlag = false;
        public string weaponImage;

        public bool cloackFlag=false;
        public string cloackImage;

        public bool ringFlag=false;
        public string ringImage;
        public int ringNumber;

        public bool amuletFlag = false;
        public string amuletImage;
        public int amuletNumber;

        public bool bootsFlag = false;
        public string bootsImage;
        public string bootsElement;

        public string shieldElement;
        public int shieldNumber;
        public bool shieldFlag = false;
        public string shieldImage;



        public string Player2runeElement1;
        public int Player2runeNumber1;
        public bool Player2runeFlag1 = false;
        public string Player2runeImage1;

        public string Player2runeElement2;
        public int Player2runeNumber2;
        public bool Player2runeFlag2 = false;
        public string Player2runeImage2;

        public string Player2runeElement3;
        public int Player2runeNumber3;
        public bool Player2runeFlag3 = false;
        public string Player2runeImage3;

        public string Player2weaponElement;
        public int Player2weaponNumber;
        public bool Player2weaponFlag = false;
        public string Player2weaponImage;

        public bool Player2cloackFlag = false;
        public string Player2cloackImage;

        public bool Player2ringFlag = false;
        public string Player2ringImage;
        public int Player2ringNumber;

        public bool Player2amuletFlag = false;
        public string Player2amuletImage;
        public int Player2amuletNumber;

        public bool Player2bootsFlag = false;
        public string Player2bootsImage;
        public string Player2bootsElement;

        public string Player2shieldElement;
        public int Player2shieldNumber;
        public bool Player2shieldFlag = false;
        public string Player2shieldImage;

        public int Player1Lvl;
        public string Player1Element;
        public bool Player1ElementSkill;
        public bool Player1Skill;
        public int Player1ElementSkillLvl;
        public int Player1SkillLvl;
        public int Player1AstralPower;
        public int Player1HP;

        public int Player2Lvl;
        public string Player2Element;
        public bool Player2ElementSkill;
        public bool Player2Skill;
        public int Player2ElementSkillLvl;
        public int Player2SkillLvl;
        public int Player2AstralPower;
        public int Player2HP;

        int Lvl;

        public void Init()
        {
            game = new Game(this);
        }
        bool end;
        bool Player2end;
        void LoadImage(Image i, string s)
        {
            Uri uri = new Uri(s);
            BitmapImage bitmap = new BitmapImage(uri);
            i.Source = bitmap;
        }
        public MainWindow()
        {
            LvlElement wLE1 = new LvlElement();
            wLE1.ShowDialog();
            Lvl = wLE1.lvl;
            if (wLE1.lvl == 9)
                Player1HP = 67;
            else
                Player1HP = 82;
            Player1Element = wLE1.NameElement;
            Player1ElementSkill = wLE1.elementSkillFlag;
            Player1Skill = wLE1.skillFlag;
            Player1ElementSkillLvl = wLE1.elementSkillLvl;
            Player1SkillLvl = wLE1.skillLvl;
            Player1AstralPower = wLE1.astralPower+1;
            end = wLE1.returnEnd();
            if (!end) this.Close();

            LvlElement wLE2 = new LvlElement(Lvl);
            wLE2.ShowDialog();
            Player2HP = Player1HP;
            Player2Element = wLE2.NameElement;
            Player2ElementSkill = wLE2.elementSkillFlag;
            Player2Skill = wLE2.skillFlag;
            Player2ElementSkillLvl = wLE2.elementSkillLvl;
            Player2SkillLvl = wLE2.skillLvl;
            Player2AstralPower = wLE2.astralPower+1;
            end = wLE2.returnEnd();
            if (!end) this.Close();
            
            ArtWindow w1 = new ArtWindow("Выбирвет первый игрок", Player1AstralPower, Lvl);
            w1.ShowDialog();
            end = w1.returnEnd();
            if (!end) this.Close();


            runeElement1 = w1.runeElement1;
            runeNumber1 = w1.runeNumber1;
            runeFlag1 = w1.runeFlag1;
            runeImage1 = w1.runeImg1;

            runeElement2 = w1.runeElement2;
            runeNumber2 = w1.runeNumber2;
            runeFlag2 = w1.runeFlag2;
            runeImage2 = w1.runeImg2;

            runeElement3 = w1.runeElement3;
            runeNumber3 = w1.runeNumber3;
            runeFlag3 = w1.runeFlag3;
            runeImage3 = w1.runeImg3;





            shieldElement = w1.shieldElement;
            shieldNumber = w1.shieldNumber;
            shieldFlag = w1.shieldFlag;
            shieldImage = w1.shieldImg;

            cloackFlag = w1.cloackFlag;
            cloackImage = w1.cloackImg;

            ringFlag = w1.ringFlag;
            ringImage = w1.ringImg;
            ringNumber = w1.ringNumber;

            bootsFlag = w1.bootsFlag;
            bootsImage = w1.bootsImg;
            bootsElement = w1.bootsElement;

            amuletFlag = w1.amuletFlag;
            amuletImage = w1.amuletImg;
            amuletNumber = w1.amuletNumber;

            weaponElement = w1.weaponElement;
            weaponNumber = w1.weaponNumber;
            weaponFlag = w1.weaponFlag;
            weaponImage = w1.weaponImg;

            end = w1.returnEnd();
            if (!end) this.Close();

            ArtWindow w2 = new ArtWindow("Выбирвет второй игрок",Player2AstralPower, Lvl);
            w2.ShowDialog();
            Player2runeElement1 = w2.runeElement1;
            Player2runeNumber1 = w2.runeNumber1;
            Player2runeFlag1 = w2.runeFlag1;
            Player2runeImage1 = w2.runeImg1;

            Player2runeElement2 = w2.runeElement2;
            Player2runeNumber2 = w2.runeNumber2;
            Player2runeFlag2 = w2.runeFlag2;
            Player2runeImage2 = w2.runeImg2;

            Player2runeElement3 = w2.runeElement3;
            Player2runeNumber3 = w2.runeNumber3;
            Player2runeFlag3 = w2.runeFlag3;
            Player2runeImage3 = w2.runeImg3;

            Player2shieldElement = w2.shieldElement;
            Player2shieldNumber = w2.shieldNumber;
            Player2shieldFlag = w2.shieldFlag;
            Player2shieldImage = w2.shieldImg;

            Player2cloackFlag = w2.cloackFlag;
            Player2cloackImage = w2.cloackImg;

            Player2ringFlag = w2.ringFlag;
            Player2ringImage = w2.ringImg;
            Player2ringNumber = w2.ringNumber;

            Player2bootsFlag = w2.bootsFlag;
            Player2bootsImage = w2.bootsImg;
            Player2bootsElement = w2.bootsElement;

            Player2amuletFlag = w2.amuletFlag;
            Player2amuletImage = w2.amuletImg;
            Player2amuletNumber = w2.amuletNumber;

            Player2weaponElement = w2.weaponElement;
            Player2weaponNumber = w2.weaponNumber;
            Player2weaponFlag = w2.weaponFlag;
            Player2weaponImage = w2.weaponImg;

            Player2end = w2.returnEnd();
            if (!Player2end) this.Close();


            Init();
            InitializeComponent();

            for (int i = 0; i < poleBuffer.Length; i++)
            {
                poleBuffer[i] = false;
            }
            game.wTest();
            ChooseGrid.Visibility = Visibility.Collapsed;
            ChooseEnemyGrid.Visibility = Visibility.Collapsed;

            LoadImage(RuneSlot1Img, runeImage1);
            LoadImage(RuneSlot2Img, runeImage2);
            LoadImage(RuneSlot3Img, runeImage3);
            LoadImage(Player2RuneSlot1Img, Player2runeImage1);
            LoadImage(Player2RuneSlot2Img, Player2runeImage2);
            LoadImage(Player2RuneSlot3Img, Player2runeImage3);
            game.Refresh();


        }

        //*******************************************************************************//

        //Оповещения
        public void ErrorMana()
        {
            MessageBox.Show("Недостаточно маны");
        }
        public void ErrorPole()
        {
            MessageBox.Show("Выберите ячейку");
        }
        public void ErrorTarget()
        {
            MessageBox.Show("Выберите существо");
        }
        public void End(Player first, Player second)
        {
            if (first.HP <= 0)
            {
                MessageBox.Show("Победил второй игрок");
                this.Close();
            }
            else
            {
                if (second.HP <= 0)
                {
                    MessageBox.Show("Победил первый игрок");
                    this.Close();
                }
            }
        }

        //*******************************************************************************//

        //*******************************************************************************//

        //Заклинания
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            game.card();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            game.TargetSpell();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // game.AllHeal();
            //game.card2();
        }

        private void Ghost_Click(object sender, RoutedEventArgs e)
        {
            game.ghost();
        }

        //*******************************************************************************//

        //Следит занята ли клетка
        public bool[] poleBuffer = new bool[11];
        //Переменная передает в какое поле вызывать существо
        public int poleNumber;
        //Переменная определяет в какое поле будет использовано заклинание
        public int targetNumber = 0;

        //*******************************************************************************//
        //Отслеживают нажатия на поля
        private void pole1Click(object sender, RoutedEventArgs e)
        {


            poleNumber = 1;


            game.FirstPlayerPoleVisible();
            pole1.Visibility = Visibility.Collapsed;
        }
        private void pole2Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 2;

            game.FirstPlayerPoleVisible();
            pole2.Visibility = Visibility.Collapsed;

        }
        private void pole3Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 3;
            game.FirstPlayerPoleVisible();
            pole3.Visibility = Visibility.Collapsed;

        }
        private void pole4Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 4;
            game.FirstPlayerPoleVisible();
            pole4.Visibility = Visibility.Collapsed;

        }
        private void pole5Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 5;
            game.FirstPlayerPoleVisible();
            pole5.Visibility = Visibility.Collapsed;

        }
        private void pole6Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 6;
            game.SecondPlayerPoleVisible();
            pole6.Visibility = Visibility.Collapsed;

        }
        private void pole7Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 7;
            game.SecondPlayerPoleVisible();
            pole7.Visibility = Visibility.Collapsed;

        }
        private void pole8Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 8;
            game.SecondPlayerPoleVisible();
            pole8.Visibility = Visibility.Collapsed;

        }
        private void pole9Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 9;
            game.SecondPlayerPoleVisible();
            pole9.Visibility = Visibility.Collapsed;

        }
        private void pole10Click(object sender, RoutedEventArgs e)
        {
            poleNumber = 10;
            game.SecondPlayerPoleVisible();
            pole10.Visibility = Visibility.Collapsed;

        }

        //*******************************************************************************//

        //RadioButton's
        private void earthButton_Checked(object sender, RoutedEventArgs e)
        {
            game.Elements();
        }
        private void fireButton_Checked(object sender, RoutedEventArgs e)
        {
            game.Elements();
        }
        private void windButton_Checked(object sender, RoutedEventArgs e)
        {
            game.Elements();
        }
        private void waterButton_Checked(object sender, RoutedEventArgs e)
        {
            game.Elements();
        }
        private void dethButton_Checked(object sender, RoutedEventArgs e)
        {
            game.Elements();
        }
        private void neitralButton_Checked(object sender, RoutedEventArgs e)
        {
            game.Elements();
        }
        private void fireEnemyButton_Checked(object sender, RoutedEventArgs e)
        {
            game.EnemyElements();
        }
        private void windEnemyButton_Checked(object sender, RoutedEventArgs e)
        {
            game.EnemyElements();
        }
        private void waterEnemyButton_Checked(object sender, RoutedEventArgs e)
        {
            game.EnemyElements();
        }
        private void earthEnemyButton_Checked(object sender, RoutedEventArgs e)
        {
            game.EnemyElements();
        }
        private void dethEnemyButton_Checked(object sender, RoutedEventArgs e)
        {
            game.EnemyElements();
        }
        private void neitralEnemyButton_Checked(object sender, RoutedEventArgs e)
        {
            game.EnemyElements();
        }

        //*******************************************************************************//
        //Пропуск хода
        private void Pas_Click(object sender, RoutedEventArgs e)
        {
            game.Pas();
        }

        //*******************************************************************************//
        //Выбор существа
        private void target1Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 1;
            game.SpellCast();
        }
        private void target2Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 2;
            game.SpellCast();
        }
        private void target3Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 3;
            game.SpellCast();
        }
        private void target4Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 4;
            game.SpellCast();
        }
        private void target5Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 5;
            game.SpellCast();
        }
        private void target6Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 6;
            game.SpellCast();
        }
        private void target7Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 7;
            game.SpellCast();
        }
        private void target8Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 8;
            game.SpellCast();
        }
        private void target9Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 9;
            game.SpellCast();
        }
        private void target10Click(object sender, RoutedEventArgs e)
        {
            targetNumber = 10;
            game.SpellCast();
        }
        //Отмена выбора существа
        private void BackClick(object sender, RoutedEventArgs e)
        {

            game.Refresh();
        }

        private void GetUp_Click(object sender, RoutedEventArgs e)
        {
            game.GetUp();
        }

        private void Runa1_Click(object sender, RoutedEventArgs e)
        {
            game.rune1();
            LoadImage(RuneSlot1Img, artFon);
            runeFlag1 = game.rune1flag;
            RuneSlot1.Visibility = Visibility.Hidden;
            RuneSlot2.Visibility = Visibility.Hidden;
            RuneSlot3.Visibility = Visibility.Hidden;
        }
        private void Runa2_Click(object sender, RoutedEventArgs e)
        {
            game.rune2();
            LoadImage(RuneSlot2Img, artFon);
            runeFlag2 = game.rune2flag;
            RuneSlot1.Visibility = Visibility.Hidden;
            RuneSlot2.Visibility = Visibility.Hidden;
            RuneSlot3.Visibility = Visibility.Hidden;
        }
        private void Runa3_Click(object sender, RoutedEventArgs e)
        {
            game.rune3();
            LoadImage(RuneSlot3Img, artFon);
            runeFlag3 = game.rune3flag;
            RuneSlot1.Visibility = Visibility.Hidden;
            RuneSlot2.Visibility = Visibility.Hidden;
            RuneSlot3.Visibility = Visibility.Hidden;
        }

        private void Player2Runa1_Click(object sender, RoutedEventArgs e)
        {
            game.Player2rune1();
            LoadImage(Player2RuneSlot1Img, artFon);
            runeFlag1 = game.rune1flag;
            Player2RuneSlot1.Visibility = Visibility.Hidden;
            Player2RuneSlot2.Visibility = Visibility.Hidden;
            Player2RuneSlot3.Visibility = Visibility.Hidden;
        }
        private void Player2Runa2_Click(object sender, RoutedEventArgs e)
        {
            game.Player2rune2();
            LoadImage(Player2RuneSlot2Img, artFon);
            runeFlag2 = game.rune2flag;
            Player2RuneSlot1.Visibility = Visibility.Hidden;
            Player2RuneSlot2.Visibility = Visibility.Hidden;
            Player2RuneSlot3.Visibility = Visibility.Hidden;
        }
        private void Player2Runa3_Click(object sender, RoutedEventArgs e)
        {
            game.Player2rune3();
            LoadImage(Player2RuneSlot3Img, artFon);
            runeFlag3 = game.rune3flag;
            Player2RuneSlot1.Visibility = Visibility.Hidden;
            Player2RuneSlot2.Visibility = Visibility.Hidden;
            Player2RuneSlot3.Visibility = Visibility.Hidden;
        }

        //private void Button_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    GoblinButton.Opacity = 50;

        //}



        //private void button_MouseEnter(object sender, MouseEventArgs e)
        //{

        //}

        public Label[] massLabel;
        public void test()
        {
            for (int i = 0; i < 5; i++)
            {

               // massLabel[i] = labelAttack;
                Label label = new Label();
                
            }
        }
        //*******************************************************************************//


    }

}