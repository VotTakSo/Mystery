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
        

        public void Init()
        {
            game = new Game(this);
        }
        bool end;
        public MainWindow()
        {
            ArtWindow w1 = new ArtWindow();
            w1.ShowDialog();

            shieldElement = w1.shieldElement;
            shieldNumber  = w1.shieldNumber;
            shieldFlag    = w1.shieldFlag;
            shieldImage   = w1.shieldImg;

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



            Init();
            InitializeComponent();
           
            for (int i = 0; i < poleBuffer.Length; i++)
            {
                poleBuffer[i] = false;
            }
            game.wTest();
            ChooseGrid.Visibility = Visibility.Collapsed;
            ChooseEnemyGrid.Visibility = Visibility.Collapsed;

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

        private void Runa_Click(object sender, RoutedEventArgs e)
        {

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