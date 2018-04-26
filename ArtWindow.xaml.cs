using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mystery
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ArtWindow : Window
    {
        public ArtWindow()
        {

            InitializeComponent();
        }

        static string artFon = "pack://application:,,,/Resources/Artefacts/test.jpg";

        public string weaponImg = "pack://application:,,,/Resources/Artefacts/test.jpg";
        public string shieldImg = "pack://application:,,,/Resources/Artefacts/test.jpg";

        public string weaponElement;
        public string shieldElement;

        public int weaponNumber;
        public int shieldNumber;

        public bool weaponFlag = false;
        public bool shieldFlag = false;

       
//******************************Загрузка изображений******************************//
        public void LoadImage(Image i, string s)
        {
            Uri uri = new Uri(s);
            BitmapImage bitmap = new BitmapImage(uri);
            i.Source = bitmap;
        }

//*************************Изображения артефактов*********************************//
        string fireBowImg = "pack://application:,,,/Resources/Artefacts/Weapon/Bow/FireBow.jpg";
        string dethSplinterImg = "pack://application:,,,/Resources/Artefacts/Weapon/Splinter/DeathSplinter.jpg";
        string dethShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/DeathShield.jpg";

//*****************************Оружие*****************************************//

        private void Bow_Click(object sender, RoutedEventArgs e)
        {
            //Window2 w = new Window2(this, weaponFlag);
            //w.ShowDialog();
            weaponFlag = true;
            weaponNumber = 1;
            weaponElement = "fire";
            WeaponButton.Visibility = Visibility.Visible;
            //FireBow.IsEnabled = false;
            weaponImg = fireBowImg;
            LoadImage(WeaponImage, weaponImg);

        }

        private void Splinter_Click(object sender, RoutedEventArgs e)
        {
            weaponFlag = true;
            weaponNumber = 2;
            weaponElement = "death";
            WeaponButton.Visibility = Visibility.Visible;
            //FireBow.IsEnabled = false;
            weaponImg = dethSplinterImg;
            LoadImage(WeaponImage, weaponImg);
        }
        private void Weapon_Click(object sender, RoutedEventArgs e)
        {
            weaponFlag = false;
            weaponNumber = 0;
            weaponElement = null;
            WeaponButton.Visibility = Visibility.Hidden;
            weaponImg = artFon;
            LoadImage(WeaponImage, weaponImg);

        }
//***********************************Щиты******************************************************//
    //*********************Малый щит смерти**********************************************//
        private void DethShield_Click(object sender, RoutedEventArgs e)
        {
            shieldFlag = true;
            shieldNumber = 1;
            shieldElement = "death";
            ShieldButton.Visibility = Visibility.Visible;
            //FireBow.IsEnabled = false;
            shieldImg = dethShieldImg;
            LoadImage(ShieldImage, shieldImg);
        }
        //Убрать щит
        private void Shield_Click(object sender, RoutedEventArgs e)
        {
            shieldFlag = false;
            shieldNumber = 0;
            shieldElement = null;
            ShieldButton.Visibility = Visibility.Hidden;
            //FireBow.IsEnabled = false;
            shieldImg = artFon;
            LoadImage(ShieldImage, shieldImg);
        }

//********************************************************************************************//
        bool end = false;

        public bool returnEnd()
        {
            return end;
        }
        private void Go_Click(object sender, RoutedEventArgs e)
        {
            end = true;
            this.Close();
        }


    }
}
